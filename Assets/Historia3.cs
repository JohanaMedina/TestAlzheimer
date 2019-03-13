using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Historia3 : MonoBehaviour {

    public GameObject text1, text2;
    public int f;
    public AudioSource voz1, voz2;
    public float t = 1.5f;

    void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);
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
            f = 2;
        }
        if (f == 2)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            f = 3;
        }
        if (f == 3)
        {
            voz2.Play();
            f = 4;        
        }
        if (f == 4 && !voz2.isPlaying)
        {
            Application.LoadLevel("Respuestas3_1");
        }
    }
}