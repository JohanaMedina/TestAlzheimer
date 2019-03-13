using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
//using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Server : MonoBehaviour
{

    //CrossPlatformInputManager.VirtualAxis m_HVAxis;
    //CrossPlatformInputManager.VirtualAxis m_VVAxis;
    //string horizontalAxisName = "Horizontal";
    //string verticalAxisName = "Vertical";
    public GameObject aviso;
    public string f1;

    void OnGUI()
    {
        string ipaddress = Network.player.ipAddress;
        GUI.Box(new Rect(10, Screen.height - 50, 100, 50), ipaddress);
        GUI.Label(new Rect(20, Screen.height - 35, 100, 20), "Status:" + NetworkServer.active);
        GUI.Label(new Rect(20, Screen.height - 20, 100, 20), "Connected:" + NetworkServer.connections.Count);
    }

    // Use this for initialization
    void Start()
    {
        aviso.SetActive(false);
        f1 = "0";
        //m_HVAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
        //CrossPlatformInputManager.RegisterVirtualAxis(m_HVAxis);
        //m_VVAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
        //CrossPlatformInputManager.RegisterVirtualAxis(m_VVAxis);

        NetworkServer.Listen(8080);
        NetworkServer.RegisterHandler(888, ServerReceiveMessage);

    }

    private void ServerReceiveMessage(NetworkMessage message)
    {
        StringMessage msg = new StringMessage();
        msg.value = message.ReadMessage<StringMessage>().value;
        string f = msg.value;
        f1 = f;
        //string[] deltas = msg.value.Split('|');
        //m_HVAxis.Update(Convert.ToSingle(deltas[0]));
        //m_VVAxis.Update(Convert.ToSingle(deltas[1]));
    }

    // Update is called once per frame
    void Update()
    {
        if (f1 == "1")
            aviso.SetActive(true);
    }
}
