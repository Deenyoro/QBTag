using System;
using System.Collections.Generic;

namespace QuickBooksModel;

public class SalesOrderLine : SalesLine
{
	private int m_SalesOrderLineSeqNo;

	private int m_SalesOrderLineGroupSeqNo;

	private string m_SalesOrderLineGroupItemGroupRefFullName;

	private string m_SalesOrderLineItemRefFullName;

	private DateTime m_TxnDate;

	private decimal m_SalesLineGroupQuantity;

	public int SalesOrderLineSeqNo
	{
		get
		{
			return m_SalesOrderLineSeqNo;
		}
		set
		{
			m_SalesOrderLineSeqNo = value;
		}
	}

	public int SalesOrderLineGroupSeqNo
	{
		get
		{
			return m_SalesOrderLineGroupSeqNo;
		}
		set
		{
			m_SalesOrderLineGroupSeqNo = value;
		}
	}

	public string SalesOrderLineGroupItemGroupRefFullName
	{
		get
		{
			return m_SalesOrderLineGroupItemGroupRefFullName;
		}
		set
		{
			m_SalesOrderLineGroupItemGroupRefFullName = value;
		}
	}

	public string SalesOrderLineItemRefFullName
	{
		get
		{
			return m_SalesOrderLineItemRefFullName;
		}
		set
		{
			m_SalesOrderLineItemRefFullName = value;
		}
	}

	public DateTime TxnDate
	{
		get
		{
			return m_TxnDate;
		}
		set
		{
			m_TxnDate = value;
		}
	}

	public decimal SalesLineGroupQuantity
	{
		get
		{
			return m_SalesLineGroupQuantity;
		}
		set
		{
			m_SalesLineGroupQuantity = value;
		}
	}

	public SalesOrderLine()
	{
		OrderInfo = new List<OrderInfo>();
	}
}
