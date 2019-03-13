using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionar2 : MonoBehaviour
{
    public GameObject bien, mal1, mal2, mal3;
    public float t1, t2, t3, t4, tiempo, tbien, t = 0.0f;
    public int bien1 = 0, f = 0, cont = 0, fv = 0, s = 0;
    public Material inicio, goodm, badm;
    public AudioSource sgood, sbad;
    public int c_errores = 0, c_aciertos = 0;
    void Start()
    {
        c_errores = PlayerPrefs.GetInt("etotal2");
        c_aciertos = PlayerPrefs.GetInt("atotal2");
        t = PlayerPrefs.GetFloat("ttotal2");
        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        bien.GetComponent<MeshRenderer>().material = inicio;
        mal1.GetComponent<MeshRenderer>().material = inicio;
        mal2.GetComponent<MeshRenderer>().material = inicio;
        mal3.GetComponent<MeshRenderer>().material = inicio;
        tiempo = 2.0f;
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

        if (tiempo < 0)
        {
            f = 1;
        }

        if (tiempo < 0)
        {
            if (t1 < 0 || t2 < 0 || t3 < 0 || t4 < 0)
            {
                if (bien1 == 2)
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
                    cont = 1;
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
                    c_errores++;
                }
                if (bien1 == 3)
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
                    c_errores++;
                }
                if (bien1 == 4)
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
                    c_errores++;
                }
            }
        }

        if (cont == 1 && !sgood.isPlaying)
        {
            PlayerPrefs.SetFloat("ttotal2", t);
            PlayerPrefs.SetInt("etotal2", c_errores);
            PlayerPrefs.SetInt("atotal2", c_aciertos);
            Application.LoadLevel("secuencias3");
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