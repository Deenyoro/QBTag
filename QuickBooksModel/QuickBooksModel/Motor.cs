namespace QuickBooksModel;

public class Motor : OrderNumber
{
	private string m_Motor;

	public string MotorValue
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
}
