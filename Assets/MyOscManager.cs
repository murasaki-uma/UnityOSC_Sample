using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityOSC;

public class MyOscManager : MonoBehaviour {
	private long _lastOscTimeStamp = -1;
	// Use this for initialization
	void Start () {
		OSCHandler.Instance.Init();
	}
	
	// Update is called once per frame
	void Update () {
		OSCHandler.Instance.UpdateLogs();
		
		foreach( KeyValuePair<string, ServerLog> item in OSCHandler.Instance.Servers ) {
			for( int i=0; i < item.Value.packets.Count; i++ ) {              if( _lastOscTimeStamp < item.Value.packets[i].TimeStamp ) {
					_lastOscTimeStamp = item.Value.packets[i].TimeStamp;
					
					string address = item.Value.packets[i].Address;
					//int userX = (int)item.Value.packets[i].Data[0];
					//int userY = (int)item.Value.packets[i].Data[1];
					
					Debug.Log( address /* + ":(" + userX + ", " + userY + ")" */ );
				}                   }                   }       
	
	}
}
