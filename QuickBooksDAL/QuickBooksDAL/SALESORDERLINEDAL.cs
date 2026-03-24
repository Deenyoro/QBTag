using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using QBFC12Lib;
using QBSalesOrder;
using QuickBooksModel;

namespace QuickBooksDAL;

public class SALESORDERLINEDAL : SALESLINEDAL
{
	[DebuggerNonUserCode]
	public SALESORDERLINEDAL()
	{
	}

	public string SelectTest(string str)
	{
		return DALUTIL.gettest(str);
	}

	public List<SalesOrderLine> SelectSalesOrderLine(string ReferenceNumber, string conStr, string AccessconStr)
	{
		ISalesOrderRetList saleRetList = ObjSalesOrder.GetSalesOrders(ReferenceNumber);
		return NEW_fetchSalesOrderLine(saleRetList);
	}

	public List<SalesOrderLine> SelectSalesOrderLineGroupItems(string ReferenceNumber, string conStr, string AccessconStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesOrderLineGroupItems(cmd);
	}

	public List<SalesOrderLine> SelectSalesOrderLine(string FromReferenceNumber, string ToReferenceNumber, string conStr, string AccessconStr)
	{
		ISalesOrderRetList saleRetList = ObjSalesOrder.GetSalesOrders(FromReferenceNumber, ToReferenceNumber);
		return NEW_fetchSalesOrderLine(saleRetList);
	}

	public List<SalesOrderLine> SelectSalesOrderLine(DateTime FromDate, DateTime ToDate, string conStr)
	{
		ISalesOrderRetList saleRetList = ObjSalesOrder.GetSalesOrders(FromDate, ToDate);
		return NEW_fetchSalesOrderLine(saleRetList);
	}

	public SalesOrderLine SelectSaleOrderLine(string ReferenceNumber, string conStr, string AccessconStr)
	{
		ISalesOrderRetList saleRetList = ObjSalesOrder.GetSalesOrders(ReferenceNumber);
		return NEW_fetchSalesOrderLine(saleRetList)?[0];
	}

	public List<SalesOrderLine> SelectSingleLineItem(string ReferenceNumber, string conStr, string AccessconStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where RefNumber='" + ReferenceNumber.ToString() + "'" + SelectWhereNowSingleLineItem(AccessconStr).ToString() + "", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSingleSalesOrderLine(cmd);
	}

	public SalesOrderLine SelectSalesOrderLineBelt(string ReferenceNumber, string PartType, string conStr)
	{
		ISalesOrderRetList saleRetList = ObjSalesOrder.GetSalesOrders(ReferenceNumber);
		return NEW_fetchSalesOrderLine(saleRetList)?[0];
	}

	public SalesOrderLine SelectSalesOrderLineMotor(string ReferenceNumber, string PartType, string conStr)
	{
		OdbcCommand cmd = new OdbcCommand("Select RefNumber,SalesOrderLineSeqNo,SalesOrderLineGroupItemGroupRefFullName,SalesOrderLineGroupQuantity,SalesOrderLineItemRefFullName,SalesOrderLineQuantity,TxnDate from SalesOrderLine where SalesOrderLineItemRefFullName LIKE '%MOTOR%' AND RefNumber='" + ReferenceNumber.ToString() + "'", DALUTIL.getQuickBooksConnection(conStr));
		return fetchSalesOrderLineMotor(cmd)?[0];
	}

	private List<SalesOrderLine> fetchSalesOrderLineMotor(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesOrderLine> SalesOrderLineList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesOrderLineList = new List<SalesOrderLine>();
				while (dr.Read())
				{
					SalesOrderLine SalesOrderLine = new SalesOrderLine();
					SalesOrderLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])))
					{
						SalesOrderLine.SalesOrderLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"]));
						string[] ItemName = SalesOrderLine.SalesOrderLineItemRefFullName.Split(':');
						if (Operators.CompareString(ItemName[0].ToString(), "MOTOR", TextCompare: false) == 0)
						{
							SalesOrderLine.Motor = ItemName[1].ToString();
						}
						else
						{
							SalesOrderLine.Motor = "";
						}
						if (ItemName[0].ToString().StartsWith("BELT"))
						{
							SalesOrderLine.Belt = ItemName[1].ToString();
						}
						else
						{
							SalesOrderLine.Belt = "";
						}
					}
					else
					{
						SalesOrderLine.SalesLineItemRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"])))
					{
						SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"]));
						SalesOrderLine.PartType = SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName;
					}
					else
					{
						SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = null;
						SalesOrderLine.PartType = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])))
					{
						SalesOrderLine.SalesLineQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"]));
					}
					else
					{
						SalesOrderLine.SalesLineQuantity = 0m;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["TxnDate"])))
					{
						SalesOrderLine.TxnDate = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr["TxnDate"]));
					}
					else
					{
						SalesOrderLine.TxnDate = DateTime.MinValue;
					}
					SalesOrderLineList.Add(SalesOrderLine);
				}
				SalesOrderLineList.TrimExcess();
			}
			return SalesOrderLineList;
		}
	}

	private List<SalesOrderLine> fetchSalesOrderLineGroupItems(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesOrderLine> SalesOrderLineList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesOrderLineList = new List<SalesOrderLine>();
				string type = default(string);
				while (dr.Read())
				{
					SalesOrderLine SalesOrderLine = new SalesOrderLine();
					SalesOrderLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					if (dr["SalesOrderLineSeqNo"] != null)
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineSeqNo"])))
						{
							SalesOrderLine.SalesOrderLineSeqNo = Conversions.ToInteger(Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineSeqNo"])));
						}
						else
						{
							SalesOrderLine.SalesOrderLineSeqNo = 0;
						}
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"])))
					{
						SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"]));
						type = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"]));
						SalesOrderLine.PartType = SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName;
					}
					else
					{
						SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = type;
						SalesOrderLine.PartType = type;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])))
					{
						SalesOrderLine.SalesOrderLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"]));
						string[] ItemName = SalesOrderLine.SalesOrderLineItemRefFullName.Split(':');
						if (ItemName[0].ToString().StartsWith("M-"))
						{
							SalesOrderLine.Motor = ItemName[1].ToString();
						}
						else
						{
							SalesOrderLine.Motor = "";
						}
						if (ItemName[0].ToString().StartsWith("B-"))
						{
							SalesOrderLine.Belt = ItemName[1].ToString();
						}
						else
						{
							SalesOrderLine.Belt = "";
						}
					}
					else
					{
						SalesOrderLine.SalesLineItemRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])))
					{
						SalesOrderLine.SalesLineQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"]));
					}
					else
					{
						SalesOrderLine.SalesLineQuantity = 0m;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupQuantity"])))
					{
						SalesOrderLine.SalesLineGroupQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupQuantity"]));
					}
					else
					{
						SalesOrderLine.SalesLineGroupQuantity = 0m;
					}
					SalesOrderLine.SerialNumber = SalesOrderLine.RefNumber + "-" + Conversions.ToString(SalesOrderLine.SalesOrderLineSeqNo) + "-" + Conversions.ToString(Convert.ToInt32(SalesOrderLine.SalesLineGroupQuantity));
					SalesOrderLine.OrderNumber = SalesOrderLine.SerialNumber;
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["TxnDate"])))
					{
						SalesOrderLine.TxnDate = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr["TxnDate"]));
					}
					else
					{
						SalesOrderLine.TxnDate = DateTime.MinValue;
					}
					if (decimal.Compare(SalesOrderLine.SalesLineQuantity, 0m) > 0)
					{
						SalesOrderLineList.Add(SalesOrderLine);
					}
				}
				SalesOrderLineList.TrimExcess();
			}
			return SalesOrderLineList;
		}
	}

	private List<SalesOrderLine> fetchSingleSalesOrderLine(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesOrderLine> SalesOrderLineList = null;
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesOrderLineList = new List<SalesOrderLine>();
				while (dr.Read())
				{
					SalesOrderLine SalesOrderLine = new SalesOrderLine();
					SalesOrderLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])))
					{
						SalesOrderLine.SalesOrderLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"]));
					}
					else
					{
						SalesOrderLine.SalesOrderLineItemRefFullName = null;
					}
				}
				SalesOrderLineList.TrimExcess();
			}
			return SalesOrderLineList;
		}
	}

	private List<SalesOrderLine> OLD_fetchSalesOrderLine(OdbcCommand cmd)
	{
		OdbcConnection con = cmd.Connection;
		List<SalesOrderLine> SalesOrderLineList = null;
		string groupName = "";
		string belt = "";
		string motor = "";
		con.Open();
		using (con)
		{
			OdbcDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				SalesOrderLineList = new List<SalesOrderLine>();
				string type = default(string);
				while (dr.Read())
				{
					SalesOrderLine SalesOrderLine = new SalesOrderLine();
					SalesOrderLine.RefNumber = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["RefNumber"]));
					SalesOrderLine.Motor = "";
					SalesOrderLine.Belt = "";
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupSeqNo"])))
					{
						SalesOrderLine.SalesOrderLineGroupSeqNo = Conversions.ToInteger(Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupSeqNo"])));
					}
					else
					{
						SalesOrderLine.SalesOrderLineGroupSeqNo = 0;
					}
					if (dr["SalesOrderLineSeqNo"] != null)
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineSeqNo"])))
						{
							SalesOrderLine.SalesOrderLineSeqNo = Conversions.ToInteger(Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineSeqNo"])));
						}
						else
						{
							SalesOrderLine.SalesOrderLineSeqNo = 0;
						}
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupSeqNo"])))
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"])))
						{
							SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"]));
							groupName = SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName;
							type = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupItemGroupRefFullName"]));
							SalesOrderLine.PartType = SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName;
						}
						else
						{
							SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = type;
							SalesOrderLine.PartType = type;
							try
							{
								if (SalesOrderLine.SalesOrderLineGroupSeqNo == 999)
								{
									SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = groupName;
									SalesOrderLine.Belt = belt;
									SalesOrderLine.Motor = motor;
									groupName = "";
									belt = "";
									motor = "";
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
						}
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"])))
					{
						SalesOrderLine.SalesOrderLineItemRefFullName = Convert.ToString(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineItemRefFullName"]));
						if (Operators.CompareString(groupName, "", TextCompare: false) != 0)
						{
							string[] ItemName = SalesOrderLine.SalesOrderLineItemRefFullName.Split(':');
							try
							{
								if (ItemName[0].ToString().StartsWith("M-"))
								{
									SalesOrderLine.Motor = ItemName[1].ToString();
									motor = ItemName[1].ToString();
								}
								else
								{
									SalesOrderLine.Motor = "";
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
							try
							{
								if (ItemName[0].ToString().StartsWith("B-"))
								{
									SalesOrderLine.Belt = ItemName[1].ToString();
									belt = ItemName[1].ToString();
								}
								else
								{
									SalesOrderLine.Belt = "";
								}
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
						}
					}
					else
					{
						SalesOrderLine.SalesLineItemRefFullName = null;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"])))
					{
						SalesOrderLine.SalesLineQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineQuantity"]));
					}
					else
					{
						SalesOrderLine.SalesLineQuantity = 0m;
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupQuantity"])))
					{
						SalesOrderLine.SalesLineGroupQuantity = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr["SalesOrderLineGroupQuantity"]));
					}
					else
					{
						SalesOrderLine.SalesLineGroupQuantity = 1m;
					}
					SalesOrderLine.SerialNumber = SalesOrderLine.RefNumber + "-" + Conversions.ToString(SalesOrderLine.SalesOrderLineSeqNo) + "-" + Conversions.ToString(Convert.ToInt32(SalesOrderLine.SalesLineQuantity));
					SalesOrderLine.OrderNumber = SalesOrderLine.SerialNumber;
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr["TxnDate"])))
					{
						SalesOrderLine.TxnDate = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr["TxnDate"]));
					}
					else
					{
						SalesOrderLine.TxnDate = DateTime.MinValue;
					}
					SalesOrderLineList.Add(SalesOrderLine);
				}
				SalesOrderLineList.TrimExcess();
			}
			return SalesOrderLineList;
		}
	}

	private List<SalesOrderLine> NEW_fetchSalesOrderLine(ISalesOrderRetList saleRetList)
	{
		if (saleRetList == null)
			return null;
		List<SalesOrderLine> SalesOrderLineList = null;
		checked
		{
			if (saleRetList.Count > 0)
			{
				SalesOrderLineList = new List<SalesOrderLine>();
				int num = saleRetList.Count - 1;
				int i = 0;
				object k = default(object);
				object LoopForResult = default(object);
				while (true)
				{
					int num2 = i;
					int num3 = num;
					if (num2 > num3)
					{
						break;
					}
					if (saleRetList.GetAt(i).ORSalesOrderLineRetList == null)
				{
					i++;
					continue;
				}
				int num4 = saleRetList.GetAt(i).ORSalesOrderLineRetList.Count - 1;
					int j = 0;
					while (true)
					{
						int num5 = j;
						num3 = num4;
						if (num5 > num3)
						{
							break;
						}
						string type = "";
						string groupName = "";
						string belt = "";
						string motor = "";
						SalesOrderLine SalesOrderLine = new SalesOrderLine();
						SalesOrderLine.RefNumber = saleRetList.GetAt(i).RefNumber.GetValue();
						SalesOrderLine.Motor = "";
						SalesOrderLine.Belt = "";
						if (saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet != null)
						{
							SalesOrderLine.SalesOrderLineGroupSeqNo = 999;
						}
						else
						{
							SalesOrderLine.SalesOrderLineGroupSeqNo = 0;
						}
						SalesOrderLine.SalesOrderLineSeqNo = j + 1;
						if (saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet != null && saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet.ItemGroupRef.FullName != null)
						{
							SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet.ItemGroupRef.FullName.GetValue();
							groupName = SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName;
							type = saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet.ItemGroupRef.FullName.GetValue();
							SalesOrderLine.PartType = SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName;
							SalesOrderLine.SalesOrderLineGroupItemGroupRefFullName = type;
							SalesOrderLine.PartType = type;
							try
							{
								if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(k, 0, saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet.SalesOrderLineRetList.Count - 1, 1, ref LoopForResult, ref k))
								{
									do
									{
										try
										{
											string[] ItemName = saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet.SalesOrderLineRetList.GetAt(Conversions.ToInteger(k)).ItemRef.FullName.GetValue().Split(':');
											try
											{
												if (ItemName[0].ToString().StartsWith("M-"))
												{
													SalesOrderLine.Motor = ItemName[1].ToString();
													motor = ItemName[1].ToString();
												}
												else
												{
													SalesOrderLine.Motor = "";
												}
											}
											catch (Exception ex)
											{
												ProjectData.SetProjectError(ex);
												Exception ex2 = ex;
												ProjectData.ClearProjectError();
											}
											try
											{
												if (ItemName[0].ToString().StartsWith("B-"))
												{
													SalesOrderLine.Belt = ItemName[1].ToString();
													belt = ItemName[1].ToString();
												}
												else
												{
													SalesOrderLine.Belt = "";
												}
											}
											catch (Exception ex3)
											{
												ProjectData.SetProjectError(ex3);
												Exception ex4 = ex3;
												ProjectData.ClearProjectError();
											}
										}
										catch (Exception ex5)
										{
											ProjectData.SetProjectError(ex5);
											Exception ex6 = ex5;
											ProjectData.ClearProjectError();
										}
									}
									while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(k, LoopForResult, ref k));
								}
								SalesOrderLine.Belt = belt;
								SalesOrderLine.Motor = motor;
								groupName = "";
								belt = "";
								motor = "";
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
						}
						if (saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineRet != null)
						{
							try
							{
								SalesOrderLine.SalesOrderLineItemRefFullName = saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineRet.ItemRef.FullName.GetValue();
							}
							catch (Exception ex7)
							{
								ProjectData.SetProjectError(ex7);
								Exception ex8 = ex7;
								SalesOrderLine.SalesOrderLineItemRefFullName = null;
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							SalesOrderLine.SalesLineItemRefFullName = null;
						}
						if (saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineRet != null)
						{
							try
							{
								SalesOrderLine.SalesLineQuantity = new decimal(saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineRet.Quantity.GetValue());
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9);
								Exception ex10 = ex9;
								SalesOrderLine.SalesLineQuantity = 0m;
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							SalesOrderLine.SalesLineQuantity = 0m;
						}
						if (saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet != null)
						{
							try
							{
								SalesOrderLine.SalesLineGroupQuantity = new decimal(saleRetList.GetAt(i).ORSalesOrderLineRetList.GetAt(j).SalesOrderLineGroupRet.Quantity.GetValue());
							}
							catch (Exception ex11)
							{
								ProjectData.SetProjectError(ex11);
								Exception ex12 = ex11;
								SalesOrderLine.SalesLineGroupQuantity = 1m;
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							SalesOrderLine.SalesLineGroupQuantity = 1m;
						}
						SalesOrderLine.SerialNumber = SalesOrderLine.RefNumber + "-" + Conversions.ToString(SalesOrderLine.SalesOrderLineSeqNo) + "-" + Conversions.ToString(Convert.ToInt32(SalesOrderLine.SalesLineQuantity));
						SalesOrderLine.OrderNumber = SalesOrderLine.SerialNumber;
						if (saleRetList.GetAt(i).TxnDate != null)
						{
							SalesOrderLine.TxnDate = saleRetList.GetAt(i).TxnDate.GetValue();
						}
						else
						{
							SalesOrderLine.TxnDate = DateTime.MinValue;
						}
						SalesOrderLineList.Add(SalesOrderLine);
						j++;
					}
					i++;
				}
				SalesOrderLineList.TrimExcess();
			}
			return SalesOrderLineList;
		}
	}
}
