using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Logs;
using QBSalesOrder;

namespace QBtag;

internal static class CLI
{
    [DllImport("kernel32.dll")]
    private static extern bool AttachConsole(int dwProcessId);

    [DllImport("kernel32.dll")]
    private static extern bool AllocConsole();

    [DllImport("kernel32.dll")]
    private static extern bool FreeConsole();

    private const int ATTACH_PARENT_PROCESS = -1;

    internal static bool HasArgs(string[] args)
    {
        return args != null && args.Length > 0;
    }

    internal static int Run(string[] args)
    {
        // Attach to parent console so output shows in cmd/powershell
        if (!AttachConsole(ATTACH_PARENT_PROCESS))
        {
            AllocConsole();
        }

        // Redirect stdout/stderr to the console
        var stdout = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        var stderr = new StreamWriter(Console.OpenStandardError()) { AutoFlush = true };
        Console.SetOut(stdout);
        Console.SetError(stderr);

        try
        {
            return Execute(args);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            return 1;
        }
        finally
        {
            FreeConsole();
        }
    }

    private static int Execute(string[] args)
    {
        string command = args[0].ToLower().TrimStart('-', '/');

        switch (command)
        {
            case "help":
            case "h":
            case "?":
                return ShowHelp();

            case "version":
            case "v":
                return ShowVersion();

            case "connect":
            case "test-connection":
                return TestConnection();

            case "disconnect":
                return Disconnect();

            case "status":
                return ShowStatus();

            case "config":
                return ShowConfig();

            case "log":
            case "logs":
                return ShowLogs(args);

            default:
                Console.Error.WriteLine("Unknown command: " + args[0]);
                Console.Error.WriteLine("Run 'QBTag --help' for usage.");
                return 1;
        }
    }

    private static int ShowHelp()
    {
        string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
        Console.WriteLine("QBTag v" + ver + " — QuickBooks Tag Printing Tool");
        Console.WriteLine();
        Console.WriteLine("Usage: QBTag [command]");
        Console.WriteLine();
        Console.WriteLine("Commands:");
        Console.WriteLine("  --help, -h          Show this help");
        Console.WriteLine("  --version, -v       Show version");
        Console.WriteLine("  --connect           Test QuickBooks connection");
        Console.WriteLine("  --disconnect        Disconnect from QuickBooks");
        Console.WriteLine("  --status            Show connection and config status");
        Console.WriteLine("  --config            Show current configuration");
        Console.WriteLine("  --logs              Show recent log entries");
        Console.WriteLine("  --logs clear        Clear all log files");
        Console.WriteLine();
        Console.WriteLine("Run without arguments to launch the GUI.");
        return 0;
    }

    private static int ShowVersion()
    {
        string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
        Console.WriteLine("QBTag v" + ver);
        return 0;
    }

    private static int TestConnection()
    {
        Console.Write("Connecting to QuickBooks... ");
        bool connected = Manager.ConnectToQB();
        if (connected)
        {
            Console.WriteLine("OK");
            Console.WriteLine("QuickBooks connection successful.");
            Manager.Disconnect();
            return 0;
        }
        else
        {
            Console.WriteLine("FAILED");
            Console.Error.WriteLine("Could not connect to QuickBooks.");
            Console.Error.WriteLine("Make sure QuickBooks Desktop is running.");
            return 1;
        }
    }

    private static int Disconnect()
    {
        Console.Write("Disconnecting from QuickBooks... ");
        try
        {
            Manager.Disconnect();
            Console.WriteLine("OK");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("FAILED");
            Console.Error.WriteLine(ex.Message);
            return 1;
        }
    }

    private static int ShowStatus()
    {
        string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
        Console.WriteLine("QBTag v" + ver);
        Console.WriteLine();

        // Config paths
        string appDir = AppDomain.CurrentDomain.BaseDirectory;
        string logDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "QBTag", "Log");

        Console.WriteLine("Install directory:  " + appDir);
        Console.WriteLine("Log directory:      " + logDir);
        Console.WriteLine("Log directory exists: " + Directory.Exists(logDir));

        // Check for key files
        Console.WriteLine();
        Console.WriteLine("Files:");
        string[] requiredFiles = new string[]
        {
            "QBTag.exe", "QBTag.exe.config",
            "Interop.QBFC12Lib.dll", "Logs.dll", "QBHelpers.dll",
            "QBSalesOrder.dll", "QuickBooksDAL.dll", "QuickBooksHandler.dll", "QuickBooksModel.dll",
            "CrystalDecisions.CrystalReports.Engine.dll", "CrystalDecisions.Shared.dll",
            "CrystalDecisions.Windows.Forms.dll", "CrystalDecisions.ReportSource.dll",
            "tag.rpt", "TagWithQRCodes.rpt"
        };
        foreach (string file in requiredFiles)
        {
            bool exists = File.Exists(Path.Combine(appDir, file));
            Console.WriteLine("  " + (exists ? "[OK]  " : "[MISS]") + " " + file);
        }

        // QuickBooks connection test
        Console.WriteLine();
        Console.Write("QuickBooks: ");
        bool connected = Manager.ConnectToQB();
        if (connected)
        {
            Console.WriteLine("Connected");
            Manager.Disconnect();
        }
        else
        {
            Console.WriteLine("Not connected (QuickBooks may not be running)");
        }

        return 0;
    }

    private static int ShowConfig()
    {
        try
        {
            string qbDataSource = My.MySettingsProperty.Settings.QuickBooksDBDataSource;
            string qbUser = My.MySettingsProperty.Settings.QuickBooksUserID;
            string accessDb = My.MySettingsProperty.Settings.AccessDBDataSource;

            Console.WriteLine("QuickBooks Data Source: " + (string.IsNullOrEmpty(qbDataSource) ? "(not set)" : qbDataSource));
            Console.WriteLine("QuickBooks User:       " + (string.IsNullOrEmpty(qbUser) ? "(not set)" : qbUser));
            Console.WriteLine("Access Database:       " + (string.IsNullOrEmpty(accessDb) ? "(not set)" : accessDb));
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Could not read config: " + ex.Message);
            return 1;
        }
        return 0;
    }

    private static int ShowLogs(string[] args)
    {
        string logDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "QBTag", "Log");

        if (!Directory.Exists(logDir))
        {
            Console.WriteLine("No log directory found at: " + logDir);
            return 0;
        }

        // Handle 'logs clear'
        if (args.Length > 1 && args[1].ToLower() == "clear")
        {
            string[] logFiles = Directory.GetFiles(logDir, "*.log");
            foreach (string f in logFiles)
            {
                try { File.Delete(f); } catch { }
            }
            Console.WriteLine("Cleared " + logFiles.Length + " log file(s).");
            return 0;
        }

        // Show recent log entries
        string[] files = Directory.GetFiles(logDir, "*.log");
        if (files.Length == 0)
        {
            Console.WriteLine("No log files found.");
            return 0;
        }

        // Find the most recent log
        string latest = files[0];
        DateTime latestTime = File.GetLastWriteTime(latest);
        foreach (string f in files)
        {
            DateTime t = File.GetLastWriteTime(f);
            if (t > latestTime)
            {
                latest = f;
                latestTime = t;
            }
        }

        Console.WriteLine("Latest log: " + Path.GetFileName(latest));
        Console.WriteLine("Modified:   " + latestTime);
        Console.WriteLine(new string('-', 60));

        // Show last 50 lines
        string[] lines = File.ReadAllLines(latest);
        int start = Math.Max(0, lines.Length - 50);
        for (int i = start; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        return 0;
    }
}
