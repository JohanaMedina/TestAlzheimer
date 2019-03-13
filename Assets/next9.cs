using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next9 : MonoBehaviour
{
    public Animation aparecer;
    public int f = 0;
    private float t = 3.0f;
    void Start()
    {

    }


    void Update()
    {
        t -= Time.deltaTime;

        if (f == 0)
        {
            aparecer.Play();
            f = 1;
        }

        if (t < 0 && !aparecer.isPlaying)
        {
            Application.LoadLevel("seleccion9" +
                "");
        }

    }
}