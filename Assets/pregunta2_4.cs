﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pregunta2_4 : MonoBehaviour {

    public AudioSource sgood, sbad, voz;
    public float tiempo, tb, t1, t2, t3, t4, tiempo2, tiempo3,t=0.0f;
    public GameObject good1, good2, bad1,bad2;
    public int f, fv, bien1, fb1 = 0, fb2 = 0, s = 0, f1 = 0;
    public Material inicio, goodm, badm;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;
    void Start()
    {
        c_errores = PlayerPrefs.GetInt("etotal1");
        c_aciertos = PlayerPrefs.GetInt("atotal1");
        t = PlayerPrefs.GetFloat("ttotal1");
        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        ec = "ehistoria1" + PlayerPrefs.GetString("nu");
        ac = "ahistoria1" + PlayerPrefs.GetString("nu");
        tc = "thistoria1" + PlayerPrefs.GetString("nu");

        tiempo = 2.0f;
        tiempo2 = 2.0f;
        tiempo3 = 2.0f;

        f = 0;
        fv = 0;

        good1.GetComponent<MeshRenderer>().material = inicio;
        good2.GetComponent<MeshRenderer>().material = inicio;
      
        bad1.GetComponent<MeshRenderer>().material = inicio;
        bad2.GetComponent<MeshRenderer>().material = inicio;

        bien1 = 0;
        tb = 1.0f;
    }

    void Update()
    {

        tiempo -= Time.deltaTime;
        t += Time.deltaTime;
        if (fv == 1)
        {
            t1 -= Time.deltaTime;
        }
        if (fv == 2)
        {
            t2 -= Time.deltaTime;
        }
        if (fv == 3)
        {
            t3 -= Time.deltaTime;
        }
        if (fv == 4)
        {
            t4 -= Time.deltaTime;
        }
       

        if (t1 < 0)
        {
            bien1 = 1;
        }
        if (t2 < 0)
        {
            bien1 = 2;
        }
        if (t3 < 0)
        {
            bien1 = 3;
        }
        if (t4 < 0)
        {
            bien1 = 4;
        }


        if (tiempo < 0 && f1 == 0)
        {
            voz.Play();
            f1 = 1;
        }

        if (f1 == 1)
            tiempo2 -= Time.deltaTime;

        if (tiempo2 < 0)
            f = 1;

        if (tiempo2 < 0)
        {
            if (t1 < 0 || t2 < 0 || t3 < 0 || t4 < 0)
            {

                if (bien1 == 3)
                {
                    if (s == 0)
                    {
                        sgood.Play();
                        s = 1;
                    }

                    tb -= Time.deltaTime;
                    c_aciertos++;
                    good1.GetComponent<MeshRenderer>().material = goodm;

                    fb1 = 1;
                }

                if (bien1 == 4)
                {
                    if (s == 0)
                    {
                        sgood.Play();
                        s = 1;
                    }

                    tb -= Time.deltaTime;

                    good2.GetComponent<MeshRenderer>().material = goodm;
                    c_aciertos++;
                    fb2 = 1;
                }

               
                if (bien1 == 1)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    tb -= Time.deltaTime;
                    c_errores++;
                    bad1.GetComponent<MeshRenderer>().material = badm;
                }

                if (bien1 == 2)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    tb -= Time.deltaTime;
                    c_errores++;
                    bad2.GetComponent<MeshRenderer>().material = badm;
                }

                if (tb < 0)
                {

                    tb = 1.0f;

                    s = 0;

                    bien1 = 0;

                    fv = 0;

                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                   
                    f = 0;
                }
            }

        }

        if (fb1 == 1 && fb2 == 1)
        {
            tiempo3 -= Time.deltaTime;
            if (tiempo3 < 0)
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            Application.LoadLevel("secuencias");
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
        if (f == 1)
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
    
}
