﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_t : MonoBehaviour {

    public Animation c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12,gaze;
    public float t;
    public int f = 0;

    void Start () {
        t = 10.0f;
	}
	

	void Update () {

        if (f == 0)
        {
            c1.Play("FlipUp");
            c2.Play("FlipUp");
            c3.Play("FlipUp");
            c4.Play("FlipUp");
            c5.Play("FlipUp");
            c6.Play("FlipUp");
            c7.Play("FlipUp");
            c8.Play("FlipUp");
            c9.Play("FlipUp");
            c10.Play("FlipUp");
            c11.Play("FlipUp");
            c12.Play("FlipUp");
            f = 1;
        }

        if (f == 1)
        {
            t -= Time.deltaTime;
        }

        if (f == 1 && t<0)
        {
            c1.Play("FlipDown");
            c2.Play("FlipDown");
            c3.Play("FlipDown");
            c4.Play("FlipDown");
            c5.Play("FlipDown");
            c6.Play("FlipDown");
            c7.Play("FlipDown");
            c8.Play("FlipDown");
            c9.Play("FlipDown");
            c10.Play("FlipDown");
            c11.Play("FlipDown");
            c12.Play("FlipDown");
            gaze.Play();
            f = 2;
        }
    }
}
