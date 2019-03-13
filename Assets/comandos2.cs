using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandos2 : MonoBehaviour
{
    //public string dato;
    //public TextMesh nombre;
    // Use this for initialization
    void Start()
    {

    }

   
    void Update()
    {
        //dato = PlayerPrefs.GetString("dato");
        //nombre.text = dato;
    }
    public void OnClick1()
    {
        Application.LoadLevel("video1");
        PlayerPrefs.SetInt("f", 1);
    }
    public void OnClick2()
    {
        Application.LoadLevel("video2");
        PlayerPrefs.SetInt("f", 2);
    }
    public void OnClick3()
    {
        Application.LoadLevel("video3");
        PlayerPrefs.SetInt("f", 3);
    }
    public void Atras()
    {
        Application.LoadLevel("menu");
    }
}
