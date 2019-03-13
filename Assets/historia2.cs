using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class historia2 : MonoBehaviour
{

    public GameObject text1;
    public int f;
    public AudioSource voz1;
    public float t = 1.5f;

    void Start()
    {
        f = 0;
    }

    void Update()
    {
        t -= Time.deltaTime;

        if (t < 0 && f == 0)
        {
            voz1.Play();
            f = 1;
        }
        if (f == 1 && !voz1.isPlaying)
        {
            Application.LoadLevel("Respuestas2_1");
        }
    }
}