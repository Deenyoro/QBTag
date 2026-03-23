using System;
using System.Data.OleDb;
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
        if (!AttachConsole(ATTACH_PARENT_PROCESS))
        {
            AllocConsole();
        }

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

            case "doctor":
            case "check":
                return RunDoctor();

            case "connect":
            case "test-connection":
                return TestConnection();

            case "disconnect":
                return Disconnect();

            case "status":
                return ShowStatus();

            case "config":
                return ShowConfig();

            case "init-db":
            case "create-db":
                return InitDatabase(args);

            case "test-db":
                return TestDatabase();

            case "set-db":
                return SetDatabase(args);

            case "list-orders":
            case "orders":
                return ListOrders();

            case "list-parts":
            case "parts":
                return ListParts();

            case "reset-config":
                return ResetConfig();

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
        Console.WriteLine("  --doctor            Full diagnostic check (run this first!)");
        Console.WriteLine("  --connect           Test QuickBooks connection");
        Console.WriteLine("  --disconnect        Disconnect from QuickBooks");
        Console.WriteLine("  --status            Show file and path status");
        Console.WriteLine("  --config            Show current configuration");
        Console.WriteLine("  --init-db [path]    Create the Access database");
        Console.WriteLine("  --test-db           Open database and verify all tables");
        Console.WriteLine("  --set-db <path>     Set the Access database path");
        Console.WriteLine("  --list-orders       List orders in the database");
        Console.WriteLine("  --list-parts        List configured part types");
        Console.WriteLine("  --reset-config      Reset all settings to defaults");
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

    // ==================== --doctor ====================
    private static int RunDoctor()
    {
        string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
        Console.WriteLine("QBTag v" + ver + " — Diagnostic Check");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine();

        int issues = 0;

        // 1. Check install files
        Console.WriteLine("[Files]");
        string appDir = AppDomain.CurrentDomain.BaseDirectory;
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
            Console.WriteLine("  " + (exists ? "OK  " : "FAIL") + "  " + file);
            if (!exists) issues++;
        }
        Console.WriteLine();

        // 2. Check data directories
        Console.WriteLine("[Directories]");
        string logDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "QBTag", "Log");
        string dataDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "QBTag");

        PrintCheck("Data directory", Directory.Exists(dataDir), dataDir, ref issues);
        PrintCheck("Log directory", Directory.Exists(logDir), logDir, ref issues);

        // Try to write a test file to verify write permissions
        bool canWrite = false;
        try
        {
            string testFile = Path.Combine(dataDir, ".write_test");
            File.WriteAllText(testFile, "test");
            File.Delete(testFile);
            canWrite = true;
        }
        catch { }
        PrintCheck("Data dir writable", canWrite, "", ref issues);
        Console.WriteLine();

        // 3. Check database
        Console.WriteLine("[Database]");
        string dbPath = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);
        PrintCheck("Database file", File.Exists(dbPath), dbPath, ref issues);

        if (File.Exists(dbPath))
        {
            // Try opening it
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath))
                {
                    con.Open();
                    PrintCheck("Database opens", true, "", ref issues);

                    // Check tables
                    string[] expectedTables = { "OrderInfo", "Parts", "tblProducts", "tblQrCode" };
                    var schema = con.GetSchema("Tables");
                    foreach (string table in expectedTables)
                    {
                        bool found = false;
                        foreach (System.Data.DataRow row in schema.Rows)
                        {
                            if (string.Equals(Convert.ToString(row["TABLE_NAME"]), table, StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                break;
                            }
                        }
                        PrintCheck("Table: " + table, found, "", ref issues);
                    }

                    // Count rows in key tables
                    try
                    {
                        using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM OrderInfo", con))
                        {
                            Console.WriteLine("  INFO  OrderInfo rows: " + cmd.ExecuteScalar());
                        }
                        using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Parts", con))
                        {
                            Console.WriteLine("  INFO  Parts rows: " + cmd.ExecuteScalar());
                        }
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                PrintCheck("Database opens", false, ex.Message, ref issues);
            }
        }
        else
        {
            Console.WriteLine("  SKIP  (run --init-db to create)");
        }
        Console.WriteLine();

        // 4. Check QuickBooks
        Console.WriteLine("[QuickBooks]");
        Console.Write("  ");
        bool qbConnected = false;
        try
        {
            qbConnected = Manager.ConnectToQB();
        }
        catch { }
        PrintCheck("QBFC12 SDK", qbConnected, qbConnected ? "" : "QuickBooks Desktop not running or SDK not installed", ref issues);
        if (qbConnected)
        {
            try { Manager.Disconnect(); } catch { }
        }
        Console.WriteLine();

        // 5. Check config
        Console.WriteLine("[Configuration]");
        try
        {
            string qbDsn = My.MySettingsProperty.Settings.QuickBooksDBDataSource;
            string qbUser = My.MySettingsProperty.Settings.QuickBooksUserID;
            string accessDb = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);
            Console.WriteLine("  QB DSN:     " + (string.IsNullOrEmpty(qbDsn) ? "(not set)" : qbDsn));
            Console.WriteLine("  QB User:    " + (string.IsNullOrEmpty(qbUser) ? "(not set)" : qbUser));
            Console.WriteLine("  Access DB:  " + (string.IsNullOrEmpty(accessDb) ? "(not set)" : accessDb));
        }
        catch (Exception ex)
        {
            Console.WriteLine("  FAIL  Could not read config: " + ex.Message);
            issues++;
        }
        Console.WriteLine();

        // 6. Check logs
        Console.WriteLine("[Logs]");
        if (Directory.Exists(logDir))
        {
            string[] logFiles = Directory.GetFiles(logDir, "*.log");
            Console.WriteLine("  Log files: " + logFiles.Length);
            if (logFiles.Length > 0)
            {
                // Find latest and show last error
                string latest = logFiles[0];
                foreach (string f in logFiles)
                {
                    if (File.GetLastWriteTime(f) > File.GetLastWriteTime(latest))
                        latest = f;
                }
                Console.WriteLine("  Latest:    " + Path.GetFileName(latest) + " (" + File.GetLastWriteTime(latest) + ")");
                try
                {
                    string[] lines = File.ReadAllLines(latest);
                    // Find last ERROR
                    for (int i = lines.Length - 1; i >= 0; i--)
                    {
                        if (lines[i].Contains("ERROR"))
                        {
                            Console.WriteLine("  Last error:");
                            for (int j = i; j < Math.Min(i + 4, lines.Length); j++)
                                Console.WriteLine("    " + lines[j]);
                            break;
                        }
                    }
                }
                catch { }
            }
        }
        else
        {
            Console.WriteLine("  No log directory");
        }
        Console.WriteLine();

        // Summary
        Console.WriteLine(new string('=', 50));
        if (issues == 0)
        {
            Console.WriteLine("All checks passed.");
        }
        else
        {
            Console.WriteLine(issues + " issue(s) found.");
        }

        return issues > 0 ? 1 : 0;
    }

    private static void PrintCheck(string label, bool ok, string detail, ref int issues)
    {
        Console.Write("  " + (ok ? "OK  " : "FAIL") + "  " + label);
        if (!string.IsNullOrEmpty(detail))
            Console.Write("  (" + detail + ")");
        Console.WriteLine();
        if (!ok) issues++;
    }

    // ==================== --test-db ====================
    private static int TestDatabase()
    {
        string dbPath = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);
        Console.WriteLine("Database: " + dbPath);

        if (!File.Exists(dbPath))
        {
            Console.Error.WriteLine("Database file not found. Run --init-db first.");
            return 1;
        }

        try
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath))
            {
                con.Open();
                Console.WriteLine("Connection: OK");
                Console.WriteLine();

                // List all tables with row counts
                var schema = con.GetSchema("Tables");
                Console.WriteLine("Tables:");
                foreach (System.Data.DataRow row in schema.Rows)
                {
                    string tableName = Convert.ToString(row["TABLE_NAME"]);
                    string tableType = Convert.ToString(row["TABLE_TYPE"]);
                    if (tableType == "SYSTEM TABLE") continue;

                    string rowCount = "?";
                    try
                    {
                        using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM [" + tableName + "]", con))
                        {
                            rowCount = Convert.ToString(cmd.ExecuteScalar());
                        }
                    }
                    catch { rowCount = "error"; }

                    Console.WriteLine("  " + tableName.PadRight(25) + " " + tableType.PadRight(8) + " " + rowCount + " rows");
                }

                // Test a write and rollback
                Console.WriteLine();
                Console.Write("Write test: ");
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(
                        "INSERT INTO OrderInfo (OrderNumber,Motor,Belt,PartType,CopiedNo) VALUES ('__TEST__','','','','0')", con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (OleDbCommand cmd = new OleDbCommand(
                        "DELETE FROM OrderInfo WHERE OrderNumber='__TEST__'", con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Console.WriteLine("OK (insert + delete verified)");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("FAILED - " + ex.Message);
                    return 1;
                }
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Could not open database: " + ex.Message);
            return 1;
        }

        Console.WriteLine();
        Console.WriteLine("Database is healthy.");
        return 0;
    }

    // ==================== Other commands ====================
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

        string appDir = AppDomain.CurrentDomain.BaseDirectory;
        string logDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "QBTag", "Log");
        string dbPath = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);

        Console.WriteLine("Install directory:    " + appDir);
        Console.WriteLine("Log directory:        " + logDir);
        Console.WriteLine("Database:             " + dbPath);
        Console.WriteLine("Database exists:      " + File.Exists(dbPath));
        Console.WriteLine("Log directory exists: " + Directory.Exists(logDir));

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
            string accessDb = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);

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

    private static int InitDatabase(string[] args)
    {
        string dbPath;
        if (args.Length > 1)
        {
            dbPath = args[1];
        }
        else
        {
            dbPath = FrmConfig.DefaultDbPath();
        }
        Console.WriteLine("Database path: " + dbPath);

        if (File.Exists(dbPath))
        {
            Console.WriteLine("Database already exists.");
            return 0;
        }

        Console.Write("Creating database... ");
        bool ok = FrmConfig.EnsureDatabaseExists(dbPath);
        if (ok && File.Exists(dbPath))
        {
            Console.WriteLine("OK");
            Console.WriteLine("Created: " + dbPath);
            return 0;
        }
        else
        {
            Console.WriteLine("FAILED");
            Console.Error.WriteLine("Could not create database. Make sure the path is writable.");
            return 1;
        }
    }

    private static int SetDatabase(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Error.WriteLine("Usage: QBTag --set-db <path>");
            Console.Error.WriteLine("Example: QBTag --set-db C:\\Data\\usman.mdb");
            return 1;
        }
        string path = args[1];
        Console.WriteLine("Setting database path to: " + path);
        try
        {
            My.MySettingsProperty.Settings.AccessDBDataSource = path;
            My.MySettingsProperty.Settings.AccessDatabaseConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            My.MySettingsProperty.Settings.Save();
            Console.WriteLine("OK — saved. Restart the app for changes to take effect.");
            if (!File.Exists(path))
            {
                Console.WriteLine("NOTE: File does not exist yet. Run --init-db to create it.");
            }
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Failed to save: " + ex.Message);
            return 1;
        }
    }

    private static int ListOrders()
    {
        string dbPath = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);
        if (!File.Exists(dbPath))
        {
            Console.Error.WriteLine("Database not found: " + dbPath);
            return 1;
        }
        try
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT OrderNumber, Motor, Belt, PartType FROM OrderInfo ORDER BY OrderNumber", con))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine(string.Format("{0,-25} {1,-15} {2,-15} {3,-15}", "OrderNumber", "Motor", "Belt", "PartType"));
                    Console.WriteLine(new string('-', 70));
                    int count = 0;
                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("{0,-25} {1,-15} {2,-15} {3,-15}",
                            Convert.ToString(reader["OrderNumber"]),
                            Convert.ToString(reader["Motor"]),
                            Convert.ToString(reader["Belt"]),
                            Convert.ToString(reader["PartType"])));
                        count++;
                    }
                    Console.WriteLine(new string('-', 70));
                    Console.WriteLine(count + " order(s).");
                }
            }
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            return 1;
        }
    }

    private static int ListParts()
    {
        string dbPath = FrmConfig.ResolveDbPath(My.MySettingsProperty.Settings.AccessDBDataSource);
        if (!File.Exists(dbPath))
        {
            Console.Error.WriteLine("Database not found: " + dbPath);
            return 1;
        }
        try
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT PartType FROM Parts ORDER BY PartType", con))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Part Types:");
                    int count = 0;
                    while (reader.Read())
                    {
                        Console.WriteLine("  " + Convert.ToString(reader["PartType"]));
                        count++;
                    }
                    if (count == 0)
                        Console.WriteLine("  (none configured)");
                    else
                        Console.WriteLine(count + " part type(s).");
                }
            }
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            return 1;
        }
    }

    private static int ResetConfig()
    {
        Console.Write("Reset all settings to defaults? (y/N): ");
        string input = Console.ReadLine();
        if (input == null || !input.Trim().ToLower().StartsWith("y"))
        {
            Console.WriteLine("Cancelled.");
            return 0;
        }
        try
        {
            My.MySettingsProperty.Settings.Reset();
            Console.WriteLine("Settings reset to defaults.");
            Console.WriteLine("Database path will be set on next launch.");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            return 1;
        }
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

        string[] files = Directory.GetFiles(logDir, "*.log");
        if (files.Length == 0)
        {
            Console.WriteLine("No log files found.");
            return 0;
        }

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

        string[] lines = File.ReadAllLines(latest);
        int start = Math.Max(0, lines.Length - 50);
        for (int i = start; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        return 0;
    }
}
