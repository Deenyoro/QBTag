namespace QuickBooksModel;

public class OrderInfo : Parts
{
	private string m_OrderNumber;

	private string m_Motor;

	private string m_Belt;

	private string m_copiedNo;

	public new string OrderNumber
	{
		get
		{
			return m_OrderNumber;
		}
		set
		{
			m_OrderNumber = value;
		}
	}

	public string Motor
	{
		get
		{
			return m_Motor;
		}
		set
		{
			m_Motor = value;
		}
	}

	public string Belt
	{
		get
		{
			return m_Belt;
		}
		set
		{
			m_Belt = value;
		}
	}

	public string CopiedNo
	{
		get
		{
			return m_copiedNo;
		}
		set
		{
			m_copiedNo = value;
		}
	}
}
