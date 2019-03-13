using UnityEngine;
using System.Collections;

public class CallRed : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SendArd.sendRed();
    }

    public void enviar()
    {
        print("Clicked");
        SendArd.sendRed();
    }
}