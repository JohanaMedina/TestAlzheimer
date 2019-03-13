using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class instruccion : MonoBehaviour {

    public AudioSource inst;
    public VideoPlayer vid;
    public GameObject escena, video;
    public int f = 0;

	void Start ()
    {
        escena.SetActive(false);
        video.SetActive(false);
	}
	
	
	void Update () {

        if (f == 0)
        {
            inst.Play();
            vid.Play();
            video.SetActive(true);
            f = 1;
        }
        
        if (!inst.isPlaying&&!vid.isPlaying)
        {
            escena.SetActive(true);
            video.SetActive(false);

        }
    }
}
