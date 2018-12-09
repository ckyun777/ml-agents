using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YKEventSender : MonoBehaviour {
	[System.Serializable]
	public class KeyToMsg
	{
		public KeyCode m_KeyCode;
		public string m_Msg;
		public string m_StrParam = "";
		public Object m_Param = null; 
	}

	public GameObject m_EventTarget;

	public KeyToMsg[] m_InputKeysToMsg;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		foreach (var item in m_InputKeysToMsg)
		{
			if(Input.GetKeyUp( item.m_KeyCode))
			{
				if(item.m_StrParam.Equals(""))
				{
					if (item.m_Param == null)
					{
						m_EventTarget.SendMessage(item.m_Msg);
					}
					else
					{
						m_EventTarget.SendMessage(item.m_Msg, item.m_Param);
					}
				}
				else
				{
					m_EventTarget.SendMessage(item.m_Msg, item.m_StrParam);
				}
				
			}

		}
	}
}
