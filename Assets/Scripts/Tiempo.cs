using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{

    private float timer;
    public GameObject aviso;
    public TextMesh label;
    public int f;

    void Start()
    {

        aviso.SetActive(false);
        timer = 10.0f;
        f = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        timer -= Time.deltaTime;
        label.text = timer.ToString("0");
        if (timer < 0)
        {
            aviso.SetActive(true);
            timer = 0;
            f = 1;
        }
        Client.bandera(f);
    }
}
