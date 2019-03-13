using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine;
//using UnityEngine.Video;

public class Client : MonoBehaviour
{

    static NetworkClient client1;
    public GameObject Button;
    //public VideoPlayer bkjg;

    void OnGUI()
    {
        string ipaddress = Network.player.ipAddress;
        GUI.Box(new Rect(10, Screen.height - 50, 100, 50), ipaddress);
        GUI.Label(new Rect(20, Screen.height - 30, 100, 20), "Status:" + client1.isConnected);

        if (!client1.isConnected)
        {
            // if(GUI.Button(new Rect(10, 10, 60, 50), "Connect"))
            //  {

            Button.SetActive(true);
            //Connect();

            // }
            
        }
        else
        {
            Button.SetActive(false);
        }

       
    }

    // Use this for initialization
    void Start()
    {

        Button.SetActive(false);
        client1 = new NetworkClient();

    }

   public void Connect()
    {
        client1.Connect("192.168.1.5", 8080);
    }

    static public void bandera(int flag)
    {
        if (client1.isConnected)
        {
            StringMessage msg = new StringMessage();
            msg.value = flag.ToString();
            client1.Send(888, msg);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (!bkjg.isPlaying)
        //    Application.LoadLevel("Juego1");

    }
}
