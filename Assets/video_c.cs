using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video_c : MonoBehaviour {
    
    public VideoPlayer video360;
    public int f = 0,cont=0;
    public float t = 43.5f,t1=0.0f;
    void Start()
    {
        video360.Play();
    }

	void Update ()
    {
        t -= Time.deltaTime;
        t1 += Time.deltaTime;

        if (t1 > 100 && PlayerPrefs.GetInt("f") == 1)
        {
            Application.LoadLevel("Juego1");
        }
        if (t1 > 100 && PlayerPrefs.GetInt("f") == 2)
        {
            Application.LoadLevel("Cartas2");
        }
        if (t1 > 100 && PlayerPrefs.GetInt("f") == 3)
        {
            Application.LoadLevel("Cartas3");
        }
       
    }
}
