using System;
using System.Collections;
using Logs;
using QBFC12Lib;

namespace QBHelpers;

public class QBRegistration
{
	protected string appName;

	protected string appID;

	protected string uiOwnerID;

	protected string uiEventID;

	protected ArrayList listDataEventIDList;

	protected ArrayList txnDataEventIDList;

	public QBRegistration(string appName, string appID, string uiOwnerID, string uiEventID, ArrayList listDataEventIDList, ArrayList txnDataEventIDList)
	{
		this.appName = appName;
		this.appID = appID;
		this.uiOwnerID = uiOwnerID;
		this.uiEventID = uiEventID;
		this.listDataEventIDList = listDataEventIDList;
		this.txnDataEventIDList = txnDataEventIDList;
	}

	public void RegisterOpenCompany(string cCallbackProgID)
	{
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			IUIEventSubscriptionAdd iUIEventSubscriptionAdd = subscriptionMsgSetRequest.AppendUIEventSubscriptionAddRq();
			iUIEventSubscriptionAdd.SubscriberID.SetValue(uiEventID);
			iUIEventSubscriptionAdd.COMCallbackInfo.AppName.SetValue(appName);
			iUIEventSubscriptionAdd.COMCallbackInfo.ORProgCLSID.ProgID.SetValue(cCallbackProgID);
			iUIEventSubscriptionAdd.CompanyFileEventSubscription.CompanyFileEventOperationList.Add(ENCompanyFileEventOperation.cfeoOpen);
			iUIEventSubscriptionAdd.DeliveryPolicy.SetValue(ENDeliveryPolicy.dpDeliverAlways);
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void UnregisterOpenCompany()
	{
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			ISubscriptionDel subscriptionDel = subscriptionMsgSetRequest.AppendSubscriptionDelRq();
			subscriptionDel.SubscriberID.SetValue(uiEventID);
			subscriptionDel.SubscriptionType.SetValue(ENSubscriptionType.stUI);
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void RegisterMenu(string cCallbackProgID, ENAddToMenu addTo, ArrayList menuName, ArrayList menuTag)
	{
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			IUIExtensionSubscriptionAdd iUIExtensionSubscriptionAdd = subscriptionMsgSetRequest.AppendUIExtensionSubscriptionAddRq();
			iUIExtensionSubscriptionAdd.SubscriberID.SetValue(uiOwnerID);
			iUIExtensionSubscriptionAdd.COMCallbackInfo.AppName.SetValue(appName);
			iUIExtensionSubscriptionAdd.COMCallbackInfo.ORProgCLSID.ProgID.SetValue(cCallbackProgID);
			iUIExtensionSubscriptionAdd.MenuExtensionSubscription.AddToMenu.SetValue(addTo);
			for (int i = 0; i < menuName.Count; i++)
			{
				AppendMenuItem((string)menuName[i], (string)menuTag[i], iUIExtensionSubscriptionAdd.MenuExtensionSubscription);
			}
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void RegisterMenu2(string cCallbackProgID, ENAddToMenu addTo, ArrayList menuName, ArrayList menuTag)
	{
		try
		{
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			IUIExtensionSubscriptionAdd iUIExtensionSubscriptionAdd = subscriptionMsgSetRequest.AppendUIExtensionSubscriptionAddRq();
			iUIExtensionSubscriptionAdd.SubscriberID.SetValue(uiOwnerID);
			iUIExtensionSubscriptionAdd.COMCallbackInfo.AppName.SetValue(appName);
			iUIExtensionSubscriptionAdd.COMCallbackInfo.ORProgCLSID.ProgID.SetValue(cCallbackProgID);
			iUIExtensionSubscriptionAdd.MenuExtensionSubscription.AddToMenu.SetValue(addTo);
			for (int i = 0; i < menuName.Count; i++)
			{
				AppendMenuItem((string)menuName[i], (string)menuTag[i], iUIExtensionSubscriptionAdd.MenuExtensionSubscription);
			}
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}

	public void UnregisterMenu()
	{
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			ISubscriptionDel subscriptionDel = subscriptionMsgSetRequest.AppendSubscriptionDelRq();
			subscriptionDel.SubscriberID.SetValue(uiOwnerID);
			subscriptionDel.SubscriptionType.SetValue(ENSubscriptionType.stUIExtension);
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void RegisterListDataEvents(string cCallbackProgID, ArrayList listEventTypes, ArrayList operations)
	{
		if (listDataEventIDList == null)
		{
			return;
		}
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			for (int i = 0; i < listDataEventIDList.Count; i++)
			{
				IDataEventSubscriptionAdd dataEventSubscriptionAdd = subscriptionMsgSetRequest.AppendDataEventSubscriptionAddRq();
				dataEventSubscriptionAdd.SubscriberID.SetValue(listDataEventIDList[i].ToString());
				dataEventSubscriptionAdd.COMCallbackInfo.AppName.SetValue(appName);
				dataEventSubscriptionAdd.COMCallbackInfo.ORProgCLSID.ProgID.SetValue(cCallbackProgID);
				dataEventSubscriptionAdd.DeliveryPolicy.SetValue(ENDeliveryPolicy.dpDeliverAlways);
				IListEventSubscription listEventSubscription = dataEventSubscriptionAdd.ListEventSubscriptionList.Append();
				listEventSubscription.ListEventTypeList.Add((ENListEventType)listEventTypes[i]);
				ArrayList arrayList = (ArrayList)operations[i];
				foreach (ENListEventOperation item in arrayList)
				{
					listEventSubscription.ListEventOperationList.Add(item);
				}
			}
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void UnregisterListDataEvents()
	{
		if (listDataEventIDList == null)
		{
			return;
		}
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			for (int i = 0; i < listDataEventIDList.Count; i++)
			{
				ISubscriptionDel subscriptionDel = subscriptionMsgSetRequest.AppendSubscriptionDelRq();
				subscriptionDel.SubscriberID.SetValue(listDataEventIDList[i].ToString());
				subscriptionDel.SubscriptionType.SetValue(ENSubscriptionType.stData);
			}
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void RegisterTxnDataEvents(string cCallbackProgID, ArrayList txnEventTypes, ArrayList operations)
	{
		if (txnDataEventIDList == null)
		{
			return;
		}
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			for (int i = 0; i < txnDataEventIDList.Count; i++)
			{
				IDataEventSubscriptionAdd dataEventSubscriptionAdd = subscriptionMsgSetRequest.AppendDataEventSubscriptionAddRq();
				dataEventSubscriptionAdd.SubscriberID.SetValue(txnDataEventIDList[i].ToString());
				dataEventSubscriptionAdd.COMCallbackInfo.AppName.SetValue(appName);
				dataEventSubscriptionAdd.COMCallbackInfo.ORProgCLSID.ProgID.SetValue(cCallbackProgID);
				dataEventSubscriptionAdd.DeliveryPolicy.SetValue(ENDeliveryPolicy.dpDeliverAlways);
				ITxnEventSubscription txnEventSubscription = dataEventSubscriptionAdd.TxnEventSubscriptionList.Append();
				txnEventSubscription.TxnEventTypeList.Add((ENTxnEventType)txnEventTypes[i]);
				ArrayList arrayList = (ArrayList)operations[i];
				foreach (ENTxnEventOperation item in arrayList)
				{
					txnEventSubscription.TxnEventOperationList.Add(item);
				}
			}
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void UnregisterTxnDataEvents()
	{
		if (txnDataEventIDList == null)
		{
			return;
		}
		try
		{
			QBCommunication.InitRegistrationManager(appName);
			ISubscriptionMsgSetRequest subscriptionMsgSetRequest = QBCommunication.QBSessionManager.CreateSubscriptionMsgSetRequest(QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			for (int i = 0; i < txnDataEventIDList.Count; i++)
			{
				ISubscriptionDel subscriptionDel = subscriptionMsgSetRequest.AppendSubscriptionDelRq();
				subscriptionDel.SubscriberID.SetValue(txnDataEventIDList[i].ToString());
				subscriptionDel.SubscriptionType.SetValue(ENSubscriptionType.stData);
			}
			Log.Add(subscriptionMsgSetRequest.ToXMLString());
			ISubscriptionMsgSetResponse subscriptionMsgSetResponse = QBCommunication.QBSessionManager.DoSubscriptionRequests(subscriptionMsgSetRequest);
			Log.Add(subscriptionMsgSetResponse.ToXMLString());
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
		finally
		{
			QBCommunication.ReleaseRegistrationManager();
		}
	}

	public void ParseEventXML(string eventXML, ref ENEventType eventType, ref string param)
	{
		try
		{
			IEventsMsgSet eventsMsgSet = QBCommunication.QBSessionManager.ToEventsMsgSet(eventXML, QBCommunication.QBXmlMajorVersion, QBCommunication.QBXmlMinorVersion);
			if (eventsMsgSet.OREvent.UIExtensionEvent != null)
			{
				eventType = ENEventType.UIExtension;
				param = eventsMsgSet.OREvent.UIExtensionEvent.EventTag.GetValue();
			}
			else if (eventsMsgSet.OREvent.UIEvent != null)
			{
				eventType = ENEventType.UI;
				param = eventsMsgSet.OREvent.UIEvent.CompanyFilePath.GetValue();
			}
			else if (eventsMsgSet.OREvent.DataEventList != null)
			{
				eventType = ENEventType.Data;
			}
			else
			{
				eventType = ENEventType.None;
			}
		}
		catch (Exception ex)
		{
			Log.Add(ex);
		}
	}

	protected void AppendMenuItem(string strName, string strTagName, IMenuExtensionSubscription ptrSub)
	{
		IMenuItem menuItem = ptrSub.ORMenuSubmenu.Submenu.MenuItemList.Append();
		menuItem.MenuText.SetValue(strName);
		menuItem.EventTag.SetValue(strTagName);
	}
}
