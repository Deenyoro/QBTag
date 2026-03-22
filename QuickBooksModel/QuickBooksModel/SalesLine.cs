using System;
using System.Collections.Generic;

namespace QuickBooksModel;

public class SalesLine : OrderInfo
{
	private int m_SalesLineSeqNo;

	private string m_RefNumber;

	private string m_SerialNumber;

	private string m_SalesLineType;

	private string m_SalesLineGroupItemGroupRefFullName;

	private string m_SalesLineItemRefFullName;

	private decimal m_SalesLineQuantity;

	private DateTime m_TimeCreated;

	private List<OrderInfo> m_OrderInfo;

	private List<Parts> m_PartType;

	public int SalesLineSeqNo
	{
		get
		{
			return m_SalesLineSeqNo;
		}
		set
		{
			m_SalesLineSeqNo = value;
		}
	}

	public string RefNumber
	{
		get
		{
			return m_RefNumber;
		}
		set
		{
			m_RefNumber = value;
		}
	}

	public string SerialNumber
	{
		get
		{
			return m_SerialNumber;
		}
		set
		{
			m_SerialNumber = value;
		}
	}

	public string SalesLineType
	{
		get
		{
			return m_SalesLineType;
		}
		set
		{
			m_SalesLineType = value;
		}
	}

	public string SalesLineGroupItemGroupRefFullName
	{
		get
		{
			return m_SalesLineGroupItemGroupRefFullName;
		}
		set
		{
			m_SalesLineGroupItemGroupRefFullName = value;
		}
	}

	public string SalesLineItemRefFullName
	{
		get
		{
			return m_SalesLineItemRefFullName;
		}
		set
		{
			m_SalesLineItemRefFullName = value;
		}
	}

	public decimal SalesLineQuantity
	{
		get
		{
			return m_SalesLineQuantity;
		}
		set
		{
			m_SalesLineQuantity = value;
		}
	}

	public DateTime TimeCreated
	{
		get
		{
			return m_TimeCreated;
		}
		set
		{
			m_TimeCreated = value;
		}
	}

	public List<OrderInfo> OrderInfo
	{
		get
		{
			return m_OrderInfo;
		}
		set
		{
			m_OrderInfo = value;
		}
	}

	public List<Parts> PartsType
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
