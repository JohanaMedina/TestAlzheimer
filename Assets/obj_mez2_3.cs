﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_mez2_3 : MonoBehaviour
{
    public AudioSource sgood, sbad;
    public float tv, tiempo, tb, tp, te, tg, tq, tiempo2, tiempo3, t = 0.0f;
    public GameObject good1, good2, good3, bad2, bad1;
    public int f, fv, bien1, fb1 = 0, fb2 = 0, fb3 = 0, s = 0;
    public Material inicio, goodm, badm;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;

    void Start()
    {
        c_errores = PlayerPrefs.GetInt("etotal4_2");
        c_aciertos = PlayerPrefs.GetInt("atotal4_2");
        t = PlayerPrefs.GetFloat("ttotal4_2");

        ec = "efiguras2" + PlayerPrefs.GetString("nu");
        ac = "afiguras2" + PlayerPrefs.GetString("nu");
        tc = "tfiguras2" + PlayerPrefs.GetString("nu");

        tv = 2.0f;
        te = 2.0f;
        tp = 2.0f;
        tg = 2.0f;
        tq = 2.0f;
        tiempo = 2.0f;
        f = 0;
        fv = 0;
        good1.GetComponent<MeshRenderer>().material = inicio;
        good2.GetComponent<MeshRenderer>().material = inicio;
        bad1.GetComponent<MeshRenderer>().material = inicio;
        bad2.GetComponent<MeshRenderer>().material = inicio;
        good3.GetComponent<MeshRenderer>().material = inicio;
        bien1 = 0;
    }

    void Update()
    {

        tiempo -= Time.deltaTime;
        t += Time.deltaTime;

        if (fv == 1)
        {
            tv -= Time.deltaTime;
        }
        if (fv == 2)
        {
            tp -= Time.deltaTime;
        }
        if (fv == 3)
        {
            te -= Time.deltaTime;
        }
        if (fv == 4)
        {
            tg -= Time.deltaTime;
        }
        if (fv == 5)
        {
            tq -= Time.deltaTime;
        }
        if (tv < 0)
        {
            bien1 = 1;
        }
        if (tp < 0)
        {
            bien1 = 2;
        }
        if (te < 0)
        {
            bien1 = 3;
        }
        if (tg < 0)
        {
            bien1 = 4;
        }
        if (tq < 0)
        {
            bien1 = 5;
        }
        if (tiempo < 0)
        {
            f = 1;
        }

        if (tiempo < 0)
        {
            if (tv < 0 || tp < 0 || te < 0 || tg < 0 || tq < 0)
            {
                if (bien1 == 2)
                {
                    if (s == 0)
                    {
                        sgood.Play();
                        s = 1;
                    }
                    good1.GetComponent<MeshRenderer>().material = goodm;
                    fb1 = 1;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    f = 0;
                    c_aciertos++;
                }
                if (bien1 == 3)
                {
                    if (s == 0)
                    {
                        sgood.Play();
                        s = 1;
                    }
                    good2.GetComponent<MeshRenderer>().material = goodm;
                    fb2 = 1;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    f = 0;
                    c_aciertos++;
                }
                if (bien1 == 4)
                {
                    if (s == 0)
                    {
                        sgood.Play();
                        s = 1;
                    }
                    good3.GetComponent<MeshRenderer>().material = goodm;
                    fb3 = 1;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    f = 0;
                    c_aciertos++;
                }
                if (bien1 == 1)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad1.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    f = 0;
                    c_errores++;
                }
                if (bien1 == 5)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad2.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    f = 0;
                    c_errores++;
                }
            }

        }

        if (fb1 == 1 && fb2 == 1 && fb3 == 1)
        {
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            Application.LoadLevel("laberinto2");
        }

    }
    public void objeto1()
    {
        if (f == 1)
        {
            fv = 1;

        }
    }
    public void objeto2()
    {
        if (f == 1 )
        {
            fv = 2;

        }
    }
    public void objeto3()
    {
        if (f == 1)
        {
            fv = 3;

        }
    }
    public void objeto4()
    {
        if (f == 1)
        {
            fv = 4;

        }
    }
    public void objeto5()
    {
        if (f == 1)
        {
            fv = 5;

        }
    }
    public void fuera()
    {
        s = 0;
        bien1 = 0;
        tv = 2.0f;
        fv = 0;
        tp = 2.0f;
        te = 2.0f;
        tg = 2.0f;
        tq = 2.0f;

        f = 0;
    }
}
