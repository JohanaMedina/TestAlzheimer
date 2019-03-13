using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voz : MonoBehaviour
{

    public AudioSource sobj1,sobj2,sobj3,sobj4,sobj5;
    public float t1, tiempo, t2, t3, t4,tiempo2,tiempo3,tiempo4,tiempo5;
    public float t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22,t=0.0f;
    public GameObject visto, mal,objs1,objs2,objs3,objs4,objs5;
    public GameObject bie1, bien2, bien3, bien4, bien5, mal1, mal2, mal3, mal4, mal5, mal6, mal7, mal8, mal9, mal10, mal11, mal12, mal13, mal14, mal15, mal16, mal17;
    public int f, fv, bien, bien1, a = 0, cont = 0, fin2 = 0, next=0,s=0;
    public TextMesh instruccion;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;
    public Material inicio, goodm, badm;
    public AudioSource sgood, sbad;

    void Start()
    {
     
        ec = "evoz1" + PlayerPrefs.GetString("nu");
        ac = "avoz1" + PlayerPrefs.GetString("nu");
        tc = "tvoz1" + PlayerPrefs.GetString("nu");

        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        t5 = 2.0f;
        t6 = 2.0f;
        t7 = 2.0f;
        t8 = 2.0f;
        t9 = 2.0f;
        t10 = 2.0f;
        t11 = 2.0f;
        t12 = 2.0f;
        t13 = 2.0f;
        t16 = 2.0f;
        t15 = 2.0f;
        t14 = 2.0f;
        t17 = 2.0f;
        t18 = 2.0f;
        t19 = 2.0f;
        t20 = 2.0f;
        t21 = 2.0f;
        t22 = 2.0f;

        bie1.GetComponent<MeshRenderer>().material = inicio;
        bien2.GetComponent<MeshRenderer>().material = inicio;
        bien3.GetComponent<MeshRenderer>().material = inicio;
        bien4.GetComponent<MeshRenderer>().material = inicio;
        bien5.GetComponent<MeshRenderer>().material = inicio;
        
        mal1.GetComponent<MeshRenderer>().material = inicio;
        mal2.GetComponent<MeshRenderer>().material = inicio;
        mal3.GetComponent<MeshRenderer>().material = inicio;
        mal4.GetComponent<MeshRenderer>().material = inicio;
        mal5.GetComponent<MeshRenderer>().material = inicio;
        mal6.GetComponent<MeshRenderer>().material = inicio;
        mal7.GetComponent<MeshRenderer>().material = inicio;
        mal8.GetComponent<MeshRenderer>().material = inicio;
        mal9.GetComponent<MeshRenderer>().material = inicio;
        mal10.GetComponent<MeshRenderer>().material = inicio;
        mal11.GetComponent<MeshRenderer>().material = inicio;
        mal12.GetComponent<MeshRenderer>().material = inicio;
        mal13.GetComponent<MeshRenderer>().material = inicio;
        mal14.GetComponent<MeshRenderer>().material = inicio;
        mal15.GetComponent<MeshRenderer>().material = inicio;
        mal16.GetComponent<MeshRenderer>().material = inicio;
        mal17.GetComponent<MeshRenderer>().material = inicio;
        
        tiempo = 2.0f;
        tiempo2 = 2.0f;
        tiempo3 = 2.0f;
        tiempo4 = 2.0f;
        tiempo5 = 2.0f;
        f = 0;
        fv = 0;
        instruccion.text = "LISTEN";
        objs1.SetActive(false);
        objs2.SetActive(false);
        objs3.SetActive(false);
        objs4.SetActive(false);
        objs5.SetActive(false);
       
       
        bien = 0;
        bien1 = 0;
        
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
        if (fv == 8)
        {
            t8 -= Time.deltaTime;
        }
        if (fv == 9)
        {
            t9 -= Time.deltaTime;
        }
        if (fv == 10)
        {
            t10 -= Time.deltaTime;
        }
        if (fv == 11)
        {
            t11 -= Time.deltaTime;
        }
        if (fv == 12)
        {
            t12 -= Time.deltaTime;
        }
        if (fv == 13)
        {
            t13 -= Time.deltaTime;
        }
        if (fv == 14)
        {
            t14 -= Time.deltaTime;
        }
        if (fv == 15)
        {
            t15 -= Time.deltaTime;
        }
        if (fv == 16)
        {
            t16 -= Time.deltaTime;
        }
        if (fv == 17)
        {
            t17 -= Time.deltaTime;
        }
        if (fv == 18)
        {
            t18 -= Time.deltaTime;
        }
        if (fv == 19)
        {
            t19 -= Time.deltaTime;
        }
        if (fv == 20)
        {
            t20 -= Time.deltaTime;
        }
        if (fv == 21)
        {
            t21 -= Time.deltaTime;
        }
        if (fv == 22)
        {
            t22 -= Time.deltaTime;
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
        if (t8 < 0)
        {
            bien1 = 8;
        }
        if (t9 < 0)
        {
            bien1 = 9;
        }
        if (t10 < 0)
        {
            bien1 = 10;
        }
        if (t11 < 0)
        {
            bien1 = 11;
        }
        if (t12 < 0)
        {
            bien1 = 12;
        }
        if (t13 < 0)
        {
            bien1 = 13;
        }
        if (t14 < 0)
        {
            bien1 = 14;
        }
        if (t15 < 0)
        {
            bien1 = 15;
        }
        if (t16 < 0)
        {
            bien1 = 16;
        }
        if (t17 < 0)
        {
            bien1 = 17;
        }
        if (t18 < 0)
        {
            bien1 = 18;
        }
        if (t19 < 0)
        {
            bien1 = 19;
        }
        if (t20 < 0)
        {
            bien1 = 20;
        }
        if (t21 < 0)
        {
            bien1 = 21;
        }
        if (t22 < 0)
        {
            bien1 = 22;
        }
        if (tiempo < 0)
        {
            f = 1;
        }

        if (f == 1 && a == 0)
        {

            sobj1.Play();
            bien = 1;
            a = 1;
        }

        if (a == 1 && !sobj1.isPlaying)
        {
            objs1.SetActive(true);
            instruccion.text = "CHOOSE";
            //empezar1.Play();
            a = 2;
            bien = 1;
        }
       
        if (f == 1 && a == 2 && next == 1)
        {
            tiempo2 -= Time.deltaTime;
            if (tiempo2 < 0)
            {
                objs1.SetActive(false);

                instruccion.text = "LISTEN";
                bien = 7;
                sobj2.Play();
                a = 3;
                s = 0;
                fv = 0;
                bien1 = 0;
                t1 = 2.0f;
                t2 = 2.0f;
                t3 = 2.0f;
                t4 = 2.0f;
                t5 = 2.0f;
                t6 = 2.0f;
                t7 = 2.0f;
                t8 = 2.0f;
                t9 = 2.0f;
                t10 = 2.0f;
                t11 = 2.0f;
                t12 = 2.0f;
                t13 = 2.0f;
                t16 = 2.0f;
                t15 = 2.0f;
                t14 = 2.0f;
                t17 = 2.0f;
                t18 = 2.0f;
                t19 = 2.0f;
                t20 = 2.0f;
                t21 = 2.0f;
                t22 = 2.0f;
                f = 0;
            }    
        }

        if(a==3 && !sobj2.isPlaying)
        {
            objs2.SetActive(true);
            instruccion.text = "CHOOSE";
            //empezar2.Play();
            a = 4;
            bien = 7;
        }

        if (f == 1 && a == 4 && next == 2)
        {
            tiempo3 -= Time.deltaTime;
            if (tiempo3 < 0)
            {
                objs2.SetActive(false);

                instruccion.text = "LISTEN";
                bien = 10;
                sobj3.Play();
                a = 5;
                s = 0;
                fv = 0;
                bien1 = 0;
                t1 = 2.0f;
                t2 = 2.0f;
                t3 = 2.0f;
                t4 = 2.0f;
                t5 = 2.0f;
                t6 = 2.0f;
                t7 = 2.0f;
                t8 = 2.0f;
                t9 = 2.0f;
                t10 = 2.0f;
                t11 = 2.0f;
                t12 = 2.0f;
                t13 = 2.0f;
                t16 = 2.0f;
                t15 = 2.0f;
                t14 = 2.0f;
                t17 = 2.0f;
                t18 = 2.0f;
                t19 = 2.0f;
                t20 = 2.0f;
                t21 = 2.0f;
                t22 = 2.0f;
                f = 0;
            }
        }

        if (a == 5 && !sobj3.isPlaying)
        {
            objs3.SetActive(true);
            instruccion.text = "CHOOSE";
            //empezar3.Play();
            a = 6;
            bien = 10;
        }

        if (f == 1 && a == 6 && next == 3)
        {
            tiempo4 -= Time.deltaTime;
            if (tiempo4 < 0)
            {
                objs3.SetActive(false);

                instruccion.text = "LISTEN";
                bien = 17;
                sobj4.Play();
                a = 7;
                s = 0;
                fv = 0;
                bien1 = 0;
                t1 = 2.0f;
                t2 = 2.0f;
                t3 = 2.0f;
                t4 = 2.0f;
                t5 = 2.0f;
                t6 = 2.0f;
                t7 = 2.0f;
                t8 = 2.0f;
                t9 = 2.0f;
                t10 = 2.0f;
                t11 = 2.0f;
                t12 = 2.0f;
                t13 = 2.0f;
                t16 = 2.0f;
                t15 = 2.0f;
                t14 = 2.0f;
                t17 = 2.0f;
                t18 = 2.0f;
                t19 = 2.0f;
                t20 = 2.0f;
                t21 = 2.0f;
                t22 = 2.0f;
                f = 0;
            }
        }

        if (a == 7 && !sobj4.isPlaying)
        {
            objs4.SetActive(true);
            instruccion.text = "CHOOSE";
            //empezar4.Play();
            a = 8;
            bien = 17;
        }

        if (f == 1 && a == 8 && next == 4)
        {
            tiempo5 -= Time.deltaTime;
            if (tiempo5 < 0)
            {
                objs4.SetActive(false);

                instruccion.text = "LISTEN";
                bien = 19;
                sobj5.Play();
                a = 9;
                s = 0;
                fv = 0;
                bien1 = 0;
                t1 = 2.0f;
                t2 = 2.0f;
                t3 = 2.0f;
                t4 = 2.0f;
                t5 = 2.0f;
                t6 = 2.0f;
                t7 = 2.0f;
                t8 = 2.0f;
                t9 = 2.0f;
                t10 = 2.0f;
                t11 = 2.0f;
                t12 = 2.0f;
                t13 = 2.0f;
                t16 = 2.0f;
                t15 = 2.0f;
                t14 = 2.0f;
                t17 = 2.0f;
                t18 = 2.0f;
                t19 = 2.0f;
                t20 = 2.0f;
                t21 = 2.0f;
                t22 = 2.0f;
                f = 0;
            }
        }

        if (a == 9 && !sobj5.isPlaying)
        {
            objs5.SetActive(true);
            instruccion.text = "CHOOSE";
            //empezar5.Play();
            a = 10;
            bien = 19;
        }

        if (tiempo < 0 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            if (t1 < 0 || t2 < 0 || t3 < 0 || t4 < 0 || t5 < 0 || t6 < 0 || t7 < 0 || t8 < 0 || t9 < 0 || t10 < 0 || t11 < 0 || t12 < 0 || t13 < 0 || t15 < 0 || t14 < 0 || t16 < 0 || t17 < 0 || t18 < 0 || t19 < 0 || t20 < 0 || t21 < 0 || t22 < 0)
            {
                if (bien1 == bien)
                {                    
                    if (bien1 == 1)
                    {
                        next = 1;
                        bie1.GetComponent<MeshRenderer>().material = goodm;
                        if (s == 0)
                        {
                            sgood.Play();
                            s = 1;
                        }
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_aciertos++;
                    }

                    if (bien1 == 7)
                    {
                        next = 2;
                        bien2.GetComponent<MeshRenderer>().material = goodm;
                        if (s == 0)
                        {
                            sgood.Play();
                            s = 1;
                        }
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_aciertos++;
                    }

                    if (bien1 == 10)
                    {
                        next = 3;
                        bien3.GetComponent<MeshRenderer>().material = goodm;
                        if (s == 0)
                        {
                            sgood.Play();
                            s = 1;
                        }
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_aciertos++;
                    }

                    if (bien1 == 17)
                    {
                        next = 4;
                        bien4.GetComponent<MeshRenderer>().material = goodm;
                        if (s == 0)
                        {
                            sgood.Play();
                            s = 1;
                        }
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_aciertos++;
                    }

                    if (bien1 == 19)
                    {
                        next = 5;
                        fin2 = 1;
                        bien5.GetComponent<MeshRenderer>().material = goodm;
                        if (s == 0)
                        {
                            sgood.Play();
                            s = 1;
                        }
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_aciertos++;
                    }

                }               
                    if (bien1 == 2)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal1.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
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
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
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
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
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
                        mal4.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;

                        c_errores++;
                    }
                    if (bien1 == 6)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal5.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 8)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal6.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;

                        c_errores++;
                    }
                    if (bien1 == 9)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal7.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 11)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal8.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;

                        c_errores++;
                    }
                    if (bien1 == 12)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal9.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 13)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal10.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;

                        c_errores++;
                    }
                    if (bien1 == 14)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal11.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;

                        c_errores++;
                    }
                    if (bien1 == 15)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal12.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 16)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal13.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 18)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal14.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 20)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal15.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 21)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal16.GetComponent<MeshRenderer>().material = badm;

                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;
                        c_errores++;
                    }
                    if (bien1 == 22)
                    {
                        if (s == 0)
                        {
                            sbad.Play();
                            s = 1;
                        }
                        mal17.GetComponent<MeshRenderer>().material = badm;
                        s = 0;
                        fv = 0;
                        bien1 = 0;
                        t1 = 2.0f;
                        t2 = 2.0f;
                        t3 = 2.0f;
                        t4 = 2.0f;
                        t5 = 2.0f;
                        t6 = 2.0f;
                        t7 = 2.0f;
                        t8 = 2.0f;
                        t9 = 2.0f;
                        t10 = 2.0f;
                        t11 = 2.0f;
                        t12 = 2.0f;
                        t13 = 2.0f;
                        t16 = 2.0f;
                        t15 = 2.0f;
                        t14 = 2.0f;
                        t17 = 2.0f;
                        t18 = 2.0f;
                        t19 = 2.0f;
                        t20 = 2.0f;
                        t21 = 2.0f;
                        t22 = 2.0f;
                        f = 0;

                        c_errores++;
                    }
                
               
            }

        }
       
        if (fin2 == 1 && !sobj5.isPlaying)
        {
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            //Application.LoadLevel("plan1");
        }

    }
    public void objeto1()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 1;
            
        }
    }
    public void objeto2()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 2;
            
        }
    }
    public void objeto3()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 3;
            
        }
    }
    public void objeto4()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 4;
        }
    }
    public void objeto5()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 5;
        }
    }
    public void objeto6()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying&&!sobj5.isPlaying)
        {
            fv = 6;
        }
    }
    public void objeto7()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 7;
        }
    }
    public void objeto8()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 8;
        }
    }
    public void objeto9()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 9;
        }
    }
    public void objeto10()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 10;
        }
    }
    public void objeto11()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 11;
        }
    }
    public void objeto12()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 12;
        }
    }
    public void objeto13()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 13;
        }
    }
    public void objeto14()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 14;
        }
    }
    public void objeto15()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 15;
        }
    }
    public void objeto16()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 16;
        }
    }
    public void objeto17()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 17;
        }
    }
    public void objeto18()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 18;
        }
    }
    public void objeto19()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 19;
        }
    }
    public void objeto20()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 20;
        }
    }
    public void objeto21()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 21;
        }
    }
    public void objeto22()
    {
        if (f == 1 && !sobj1.isPlaying && !sobj2.isPlaying && !sobj3.isPlaying && !sobj4.isPlaying && !sobj5.isPlaying)
        {
            fv = 22;
        }
    }
}

