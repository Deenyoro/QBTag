using System.Runtime.CompilerServices;

namespace QuickBooksModel;

public class QrCodes
{
	private string m_Link;

	private string m_ProductNumber;

	private object m_QrPhoto;

	public string Link
	{
		get
		{
			return m_Link;
		}
		set
		{
			m_Link = value;
		}
	}

	public string ProductNumber
	{
		get
		{
			return m_ProductNumber;
		}
		set
		{
			m_ProductNumber = value;
		}
	}

	public object QrPhoto
	{
		get
		{
			return m_QrPhoto;
		}
		set
		{
			m_QrPhoto = RuntimeHelpers.GetObjectValue(value);
		}
	}
}
