namespace QuickBooksModel;

public class Parts : OrderNumber
{
	private string m_PartType;

	public string PartType
	{
		get
		{
			return m_PartType;
		}
		set
		{
			m_PartType = value;
		}
	}
}
