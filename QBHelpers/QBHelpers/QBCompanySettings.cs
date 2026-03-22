using System;
using System.Collections;
using Logs;
using QBFC12Lib;

namespace QBHelpers;

public class QBCompanySettings
{
	private Hashtable myDataExtHT;

	private static string strOwnerID;

	public string this[string keyName]
	{
		get
		{
			return GetKey(keyName);
		}
		set
		{
			PutKey(keyName, value);
		}
	}

	public int Count
	{
		get
		{
			if (myDataExtHT != null)
			{
				return myDataExtHT.Count;
			}
			return 0;
		}
	}

	public static string StrOwnerID
	{
		get
		{
			return strOwnerID;
		}
		set
		{
			strOwnerID = ((value == null) ? "" : value);
		}
	}

	public QBCompanySettings(string ownerID)
	{
		strOwnerID = ownerID;
		Open();
	}

	private void Open()
	{
		myDataExtHT = new Hashtable();
		try
		{
			IMsgSetRequest msgSetRequest = QBCommunication.QBSessionManager.CreateMsgSetRequest("US", QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			ICompanyQuery companyQuery = msgSetRequest.AppendCompanyQueryRq();
			companyQuery.OwnerIDList.Add(strOwnerID);
			IMsgSetResponse msgSetResponse = QBCommunication.QBSessionManager.DoRequests(msgSetRequest);
			LogQB.Add("", msgSetRequest, msgSetResponse);
			ICompanyRet companyRet = (ICompanyRet)msgSetResponse.ResponseList.GetAt(0).Detail;
			if (companyRet.DataExtRetList == null)
			{
				return;
			}
			for (int i = 0; i < companyRet.DataExtRetList.Count; i++)
			{
				IDataExtRet at = companyRet.DataExtRetList.GetAt(i);
				string text = at.DataExtValue.GetValue();
				if (text.Length > 0)
				{
					text = text.Remove(0, 1);
				}
				if (text.Length > 0)
				{
					text = text.Remove(text.Length - 1, 1);
				}
				myDataExtHT.Add(at.DataExtName.GetValue(), text);
			}
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}

	private string GetKey(string keyName)
	{
		if (myDataExtHT[keyName] != null)
		{
			return myDataExtHT[keyName].ToString();
		}
		return null;
	}

	private void PutKey(string keyName, string keyValue)
	{
		if (myDataExtHT[keyName] == null)
		{
			QBInsertKey(keyName, keyValue);
		}
		else
		{
			QBModifyKey(keyName, keyValue);
		}
	}

	private void QBInsertKey(string keyName, string keyValue)
	{
		try
		{
			IMsgSetRequest msgSetRequest = QBCommunication.QBSessionManager.CreateMsgSetRequest("US", QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			msgSetRequest.Attributes.OnError = ENRqOnError.roeContinue;
			IDataExtDefAdd dataExtDefAdd = msgSetRequest.AppendDataExtDefAddRq();
			dataExtDefAdd.AssignToObjectList.Add(ENAssignToObject.atoCompany);
			dataExtDefAdd.DataExtType.SetValue(ENDataExtType.detSTR1024TYPE);
			dataExtDefAdd.DataExtName.SetValue(keyName);
			dataExtDefAdd.OwnerID.SetValue(strOwnerID);
			IDataExtAdd dataExtAdd = msgSetRequest.AppendDataExtAddRq();
			dataExtAdd.DataExtName.SetValue(keyName);
			string value = $"'{keyValue}'";
			dataExtAdd.DataExtValue.SetValue(value);
			dataExtAdd.OwnerID.SetValue(strOwnerID);
			dataExtAdd.ORListTxnWithMacro.OtherDataExtType.SetValue(ENOtherDataExtType.odetCompany);
			IMsgSetResponse msgSetResponse = QBCommunication.QBSessionManager.DoRequests(msgSetRequest);
			LogQB.Add("", msgSetRequest, msgSetResponse);
			if (msgSetResponse.ResponseList.GetAt(1).StatusCode == 0)
			{
				myDataExtHT.Add(keyName, keyValue);
			}
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}

	private void QBModifyKey(string keyName, string keyValue)
	{
		try
		{
			IMsgSetRequest msgSetRequest = QBCommunication.QBSessionManager.CreateMsgSetRequest("US", QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			msgSetRequest.Attributes.OnError = ENRqOnError.roeStop;
			IDataExtMod dataExtMod = msgSetRequest.AppendDataExtModRq();
			dataExtMod.DataExtName.SetValue(keyName);
			string value = $"'{keyValue}'";
			dataExtMod.DataExtValue.SetValue(value);
			dataExtMod.OwnerID.SetValue(strOwnerID);
			dataExtMod.ORListTxn.OtherDataExtType.SetValue(ENOtherDataExtType.odetCompany);
			IMsgSetResponse msgSetResponse = QBCommunication.QBSessionManager.DoRequests(msgSetRequest);
			LogQB.Add("", msgSetRequest, msgSetResponse);
			if (msgSetResponse.ResponseList.GetAt(0).StatusCode == 0)
			{
				myDataExtHT[keyName] = keyValue;
			}
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}
}
