using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afirmacion3 : MonoBehaviour
{

    public AudioSource sgood, sbad, afirmation;
    public float tb, tiempo, t1, t2, tiempo2,t=0.0f;
    public GameObject good1, bad1;
    public int f, fv, bien1, fb1 = 0, s = 0, f1 = 0;
    public Material inicio, goodm, badm;
    public int c_errores = 0, c_aciertos = 0;

    void Start()
    {
        c_errores = PlayerPrefs.GetInt("etotal3");
        c_aciertos = PlayerPrefs.GetInt("atotal3");
        t = PlayerPrefs.GetFloat("ttotal3");

        t1 = 2.0f;
        t2 = 2.0f;

        tiempo = 2.0f;
        tiempo2 = 2.0f;

        f = 0;
        fv = 0;

        good1.GetComponent<MeshRenderer>().material = inicio;
        bad1.GetComponent<MeshRenderer>().material = inicio;

        bien1 = 0;
    }

    void Update()
    {
        if (f1 == 0)
        {
            afirmation.Play();
            f1 = 1;
        }

        if (f1 == 1 && !afirmation.isPlaying)
        {
            t += Time.deltaTime;
            tiempo -= Time.deltaTime;
        }
            if (fv == 1)
            {
                t1 -= Time.deltaTime;
            }
            if (fv == 2)
            {
                t2 -= Time.deltaTime;
            }

            if (t1 < 0)
            {
                bien1 = 1;
            }
            if (t2 < 0)
            {
                bien1 = 2;
            }

            if (tiempo < 0)
            {
                f = 1;
            }

            if (tiempo < 0)
            {
                if (t1 < 0 || t2 < 0)
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
                        fv = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
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
                        fv = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                }
            }

            if (fb1 == 1)
            {
                tiempo2 -= Time.deltaTime;
                if (tiempo2 < 0)
                {
                    PlayerPrefs.SetFloat("ttotal3", t);
                    PlayerPrefs.SetInt("etotal3", c_errores);
                    PlayerPrefs.SetInt("atotal3", c_aciertos);
                    Application.LoadLevel("afirmaciones4");
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
    public void fuera()
    {
        bien1 = 0;
        fv = 0;
        t1 = 2.0f;
        t2 = 2.0f;
        f = 0;
    }
}
