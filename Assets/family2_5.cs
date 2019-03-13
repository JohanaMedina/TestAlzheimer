using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class family2_5 : MonoBehaviour
{
    public GameObject bien, mal1, mal2, mal3, mal4, mal5, mal6, obj, objs, mallas;
    public float t1, t2, t3, t4, t5, t6, t7, tiempo, tbien, t = 0.0f;
    public int bien1 = 0, f = 0, a = 0, b = 0, cont4 = 0, fv = 0, s = 0;
    public Animation objet, giro;
    public Material inicio, goodm, badm;
    public AudioSource sgood, sbad;
    public family2_4 cont3;
    public int c_errores = 0, c_aciertos = 0, f1 = 0;
    public string tc, ec, ac;

    void Start()
    {
        ec = "ecaras2" + PlayerPrefs.GetString("nu");
        ac = "acaras2" + PlayerPrefs.GetString("nu");
        tc = "tcaras2" + PlayerPrefs.GetString("nu");

        objs.SetActive(false);
        obj.SetActive(false);
        mallas.SetActive(false);
        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        t5 = 2.0f;
        t6 = 2.0f;
        t7 = 2.0f;
        bien.GetComponent<MeshRenderer>().material = inicio;
        mal1.GetComponent<MeshRenderer>().material = inicio;
        mal2.GetComponent<MeshRenderer>().material = inicio;
        mal3.GetComponent<MeshRenderer>().material = inicio;
        mal4.GetComponent<MeshRenderer>().material = inicio;
        mal5.GetComponent<MeshRenderer>().material = inicio;
        mal6.GetComponent<MeshRenderer>().material = inicio;
        tiempo = 2.0f;
    }


    void Update()
    {
        tiempo -= Time.deltaTime;
        t += Time.deltaTime;

        if (cont3.cont3 == 1)
        {
            obj.SetActive(true);

            if (b == 0)
            {
                objet.Play();
                b = 1;
            }
            if (a == 0 && b == 1 && !objet.isPlaying)
            {
                objs.SetActive(true);
                obj.SetActive(false);
                giro.Play();
                a = 1;
            }
            if (a == 1 && !giro.isPlaying)
            {
                mallas.SetActive(true);
                a = 2;
            }
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
            if (fv == 5)
            {
                t5 -= Time.deltaTime;
            }
            if (fv == 6)
            {
                t6 -= Time.deltaTime;
            }
            if (fv == 7)
            {
                t7 -= Time.deltaTime;
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
            if (t5 < 0)
            {
                bien1 = 5;
            }
            if (t6 < 0)
            {
                bien1 = 6;
            }
            if (t7 < 0)
            {
                bien1 = 7;
            }
            if (tiempo < 0)
            {
                f = 1;
            }
            if (tiempo < 0)
            {
                if (t1 < 0 || t2 < 0 || t3 < 0 || t4 < 0 || t5 < 0 || t6 < 0 || t7 < 0)
                {
                    if (bien1 == 6)
                    {
                        if (s == 0)
                        {
                            sgood.Play();
                            s = 1;
                        }
                        bien.GetComponent<MeshRenderer>().material = goodm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        cont4 = 1;
                        c_aciertos++;
                    }
                    if (bien1 == 1)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal1.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        c_errores++;
                    }
                    if (bien1 == 2)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal2.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        c_errores++;
                    }
                    if (bien1 == 3)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal3.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        c_errores++;
                    }
                    if (bien1 == 4)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal4.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        c_errores++;
                    }
                    if (bien1 == 5)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal5.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        c_errores++;
                    }
                    if (bien1 == 7)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal6.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        fv = 0;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        c_errores++;
                    }
                }
            }
            if (cont4 == 1 && f1==0)
            {
                c_errores = PlayerPrefs.GetInt("etotal_2") + c_errores;
                c_aciertos = PlayerPrefs.GetInt("atotal_2") + c_aciertos;
                PlayerPrefs.SetString(tc, t.ToString("f0"));
                PlayerPrefs.SetString(ec, c_errores.ToString());
                PlayerPrefs.SetString(ac, c_aciertos.ToString());
                Application.LoadLevel("historia2");
                f1 = 1;
            }

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
}