using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clima3_1 : MonoBehaviour
{

    public AudioSource sgood, sbad;
    public float tv, tiempo, tb, tp, te, tg, tq, ts, ta, ti, t1, t2, t3, t4, t5, t6, t7, t8, tiempo2, tiempo3, t = 0.0f;
    public GameObject good1, good2, good3, good4, bad1, bad2, bad3, bad4, bad5, bad6, bad7, bad8,bad9,bad10,bad11,bad12;
    public int f, fv, bien1, fb1 = 0, fb2 = 0, fb3 = 0, fb4 = 0, s = 0;
    public Material inicio, goodm, badm;
    public int c_errores = 0, c_aciertos = 0;

    void Start()
    {
        PlayerPrefs.SetInt("etotal6_3", 0);
        PlayerPrefs.SetInt("atotal6_3", 0);
        PlayerPrefs.SetFloat("ttotal6_3", 0);

        tv = 2.0f;
        te = 2.0f;
        tp = 2.0f;
        tg = 2.0f;
        tq = 2.0f;
        ts = 2.0f;
        ta = 2.0f;
        ti = 2.0f;
        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        t5 = 2.0f;
        t6 = 2.0f;
        t7 = 2.0f;
        t8 = 2.0f;
        tiempo = 2.0f;
        f = 0;
        fv = 0;
        good1.GetComponent<MeshRenderer>().material = inicio;
        good2.GetComponent<MeshRenderer>().material = inicio;
        bad1.GetComponent<MeshRenderer>().material = inicio;
        bad2.GetComponent<MeshRenderer>().material = inicio;
        bad3.GetComponent<MeshRenderer>().material = inicio;
        bad4.GetComponent<MeshRenderer>().material = inicio;
        bad5.GetComponent<MeshRenderer>().material = inicio;
        bad6.GetComponent<MeshRenderer>().material = inicio;
        bad7.GetComponent<MeshRenderer>().material = inicio;
        bad8.GetComponent<MeshRenderer>().material = inicio;
        bad9.GetComponent<MeshRenderer>().material = inicio;
        bad10.GetComponent<MeshRenderer>().material = inicio;
        bad11.GetComponent<MeshRenderer>().material = inicio;
        bad12.GetComponent<MeshRenderer>().material = inicio;
        good3.GetComponent<MeshRenderer>().material = inicio;
        good4.GetComponent<MeshRenderer>().material = inicio;
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
        if (fv == 6)
        {
            ts -= Time.deltaTime;
        }
        if (fv == 7)
        {
            ta -= Time.deltaTime;
        }
        if (fv == 8)
        {
            ti -= Time.deltaTime;
        }
        if (fv == 9)
        {
            t1 -= Time.deltaTime;
        }
        if (fv == 10)
        {
            t2 -= Time.deltaTime;
        }
        if (fv == 11)
        {
            t3 -= Time.deltaTime;
        }
        if (fv == 12)
        {
            t4 -= Time.deltaTime;
        }
        if (fv == 13)
        {
            t5 -= Time.deltaTime;
        }
        if (fv == 14)
        {
            t6 -= Time.deltaTime;
        }
        if (fv == 15)
        {
            t7 -= Time.deltaTime;
        }
        if (fv == 16)
        {
            t8 -= Time.deltaTime;
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
        if (ts < 0)
        {
            bien1 = 6;
        }
        if (ta < 0)
        {
            bien1 = 7;
        }
        if (ti < 0)
        {
            bien1 = 8;
        }
        if (t1 < 0)
        {
            bien1 = 9;
        }
        if (tiempo < 0)
        {
            f = 1;
        }
        if (t2 < 0)
        {
            bien1 = 10;
        }
        if (t3 < 0)
        {
            bien1 = 11;
        }
        if (t4 < 0)
        {
            bien1 = 12;
        }
        if (t5 < 0)
        {
            bien1 = 13;
        }
        if (t6 < 0)
        {
            bien1 = 14;
        }
        if (t7 < 0)
        {
            bien1 = 15;
        }
        if (t8 < 0)
        {
            bien1 = 16;
        }

        if (tiempo < 0)
        {
            if (tv < 0 || tp < 0 || te < 0 || tg < 0 || tq < 0 || ts < 0 || ta < 0 || ti < 0 || t1 < 0 || t2 < 0 || t3 < 0 || t4 < 0 || t5< 0 || t6 < 0 || t7 < 0 || t8 < 0)
            {
                if (bien1 == 3)
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
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_aciertos++;
                }
                if (bien1 == 5)
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
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_aciertos++;
                }
                if (bien1 == 11)
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
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_aciertos++;
                }
                if (bien1 == 15)
                {
                    if (s == 0)
                    {
                        sgood.Play();
                        s = 1;
                    }
                    good4.GetComponent<MeshRenderer>().material = goodm;
                    fb4 = 1;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
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
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 2)
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
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 4)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad3.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 6)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad4.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 7)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad5.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 8)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad6.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 9)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad7.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 10)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad8.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 12)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad9.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 13)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad10.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 14)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad11.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
                if (bien1 == 16)
                {
                    if (s == 0)
                    {
                        sbad.Play();
                        s = 1;
                    }
                    bad12.GetComponent<MeshRenderer>().material = badm;
                    s = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tq = 2.0f;
                    ts = 2.0f;
                    ta = 2.0f;
                    ti = 2.0f;
                    t1 = 2.0f;
                    t2 = 2.0f;
                    t3 = 2.0f;
                    t4 = 2.0f;
                    t5 = 2.0f;
                    t6 = 2.0f;
                    t7 = 2.0f;
                    t8 = 2.0f;
                    c_errores++;
                }
            }

        }

        if (fb1 == 1 && fb2 == 1 && fb3 == 1 && fb4 == 1)
        {
            if (c_aciertos > 4)
                c_aciertos = 4;
            PlayerPrefs.SetFloat("ttotal6_3", t);
            PlayerPrefs.SetInt("etotal6_3", c_errores);
            PlayerPrefs.SetInt("atotal6_3", c_aciertos);
            Application.LoadLevel("clima3_2"); ;
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
    public void objeto5()
    {
        if (f == 1)
        {
            fv = 5;

        }
    }
    public void objeto6()
    {
        if (f == 1)
        {
            fv = 6;

        }
    }
    public void objeto7()
    {
        if (f == 1)
        {
            fv = 7;

        }
    }
    public void objeto8()
    {
        if (f == 1)
        {
            fv = 8;

        }
    }
    public void objeto9()
    {
        if (f == 1)
        {
            fv = 9;

        }
    }
    public void objeto10()
    {
        if (f == 1)
        {
            fv = 10;

        }
    }
    public void objeto11()
    {
        if (f == 1)
        {
            fv = 11;

        }
    }
    public void objeto12()
    {
        if (f == 1)
        {
            fv = 12;

        }
    }
    public void objeto13()
    {
        if (f == 1)
        {
            fv = 13;

        }
    }
    public void objeto14()
    {
        if (f == 1)
        {
            fv = 14;

        }
    }
    public void objeto15()
    {
        if (f == 1)
        {
            fv = 15;

        }
    }
    public void objeto16()
    {
        if (f == 1)
        {
            fv = 16;

        }
    }
    public void fuera()
    {
        tv = 2.0f;
        fv = 0;
        tp = 2.0f;
        te = 2.0f;
        tg = 2.0f;
        tq = 2.0f;
        ts = 2.0f;
        ta = 2.0f;
        ti = 2.0f;
        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        t5 = 2.0f;
        t6 = 2.0f;
        t7 = 2.0f;
        t8 = 2.0f;
    }
}
