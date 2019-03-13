using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vestimenta : MonoBehaviour {

    public Animation jeans1, gorro1, cinturon1, medias1, tennis1, blusa1, jacket1;
    public float tj = 2.0f, tg = 2.0f, tc = 2.0f, tm = 2.0f, tt = 2.0f, tb = 2.0f, tjk = 2.0f;
    public int f = 0, a = 0, fj = 0, fg = 0, fc = 0, fm = 0, ft = 0, fb = 0, fjk = 0, cont = 0;
    public int fin = 0, c1, c2, c3, c4, c5, c6, c7;
    public AudioSource selec, aplausos;

	void Start () {

        c1 = 0;
        c2 = 0;
        c3 = 0;
        c4 = 0;
        c5 = 0;
        c6 = 0;
        c7 = 0;

	}
	
	
	void Update () {

        cont = c1 + c2 + c3 + c4 + c5 + c6 + c7;

        if (f == 1)
        {
            tj -= Time.deltaTime;
        }
        if (f == 2)
        {
            tg -= Time.deltaTime;
        }
        if (f == 3)
        {
            tc -= Time.deltaTime;
        }
        if (f == 4)
        {
            tm -= Time.deltaTime;
        }
        if (f == 5)
        {
            tt -= Time.deltaTime;
        }
        if (f == 6)
        {
            tb -= Time.deltaTime;
        }
        if (f == 7)
        {
            tjk -= Time.deltaTime;
        }
        if (tj < 0 && f == 1)
        {
            a = 1;
        }
        if (tg < 0 && f == 2)
        {
            a = 2;
        }
        if (tc < 0 && f == 3)
        {
            a = 3;
        }
        if (tm < 0 && f == 4)
        {
            a = 4;
        }
        if (tt < 0 && f == 5)
        {
            a = 5;
        }
        if (tb < 0 && f == 6)
        {
            a = 6;
        }
        if (tjk < 0 && f == 7)
        {
            a = 7;
        }
        if (a == 1)
        {
            jeans1.Play();
            selec.Play();
            fj = 1;
            f = 0;
            a = 0;
            c1 = 1;
        }
        if (a == 2)
        {
            gorro1.Play();
            selec.Play();
            fg = 1;
            f = 0;
            a = 0;
            c2 = 1;
        }
        if (a == 3)
        {
            cinturon1.Play();
            selec.Play();
            fc = 1;
            f = 0;
            a = 0;
            c3 = 1;
        }
        if (a == 4)
        {
            medias1.Play();
            selec.Play();
            fm = 1;
            f = 0;
            a = 0;
            c4 = 1;
        }
        if (a == 5)
        {
            tennis1.Play();
            selec.Play();
            ft = 1;
            f = 0;
            a = 0;
            c5 = 1;
        }
        if (a == 6)
        {
            blusa1.Play();
            selec.Play();
            fb = 1;
            f = 0;
            a = 0;
            c6 = 1;
        }
        if (a == 7)
        {
            jacket1.Play();
            selec.Play();
            fjk = 1;
            f = 0;
            a = 0;
            c7 = 1;
        }
        if (cont == 7&& fin==0)
        {
            aplausos.Play();
            fin = 1;
        }
        if (fin == 1 && !aplausos.isPlaying)
        {
            Application.LoadLevel("juego4");
        }
    }
    public void jeans()
    {
        if (fj == 0)
        {
            f = 1;
            tj = 2.0f;
        }      

    }
    public void gorro()
    {
        if (fg == 0)
        {
            f = 2;
            tg = 2.0f;
        }
    }
    public void cinturon()
    {
        if (fc == 0)
        {
            f = 3;
            tc = 2.0f;
        }
    }
    public void medias()
    {
        if (fm == 0)
        {
            f = 4;
            tm = 2.0f;
        }
    }
    public void tennis()
    {
        if (ft == 0)
        {
            f = 5;
            tt = 2.0f;
        }
    }
    public void blusa()
    {
        if (fb == 0)
        {
            f = 6;
            tb = 2.0f;
        }
    }
    public void jacket()
    {
        if (fjk == 0)
        {
            f = 7;
            tjk = 2.0f;
        }
    }
}
