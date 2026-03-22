namespace QuickBooksModel;

public class Belt : Motor
{
	private string m_Belt;

	public string BeltValue
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
}
