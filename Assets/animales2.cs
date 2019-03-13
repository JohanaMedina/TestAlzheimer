using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animales2 : MonoBehaviour
{

    public AudioSource Svaca, Sperro, Selefante, Sgato, Scaballo, Sapluaso;
    public float tv, tiempo, tb, tp, te, tg, tc;
    public GameObject aviso, visto, mal;
    public int f, fv, bien, bien1, a = 0, cont = 0, fin = 0, fin2 = 0;

    void Start()
    {
        tv = 2.0f;
        te = 2.0f;
        tp = 2.0f;
        tg = 2.0f;
        tc = 2.0f;
        tiempo = 5.0f;
        f = 0;
        fv = 0;
        aviso.SetActive(true);
        visto.SetActive(false);
        mal.SetActive(false);
        bien = 0;
        bien1 = 0;
        tb = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo < 0)
        {
            f = 1;
            aviso.SetActive(false);
        }
        if (f == 1 && a == 0 && cont == 0)
        {
            Svaca.Play();
            bien = 1;
            a = 1;
        }
        if (f == 1 && cont == 1 && a == 0)
        {
            Sperro.Play();
            bien = 2;
            a = 1;
        }
        if (f == 1 && cont == 2 && a == 0)
        {
            Selefante.Play();
            bien = 3;
            a = 1;
        }
        if (f == 1 && cont == 3 && a == 0)
        {
            Sgato.Play();
            bien = 4;
            a = 1;
        }
        if (f == 1 && cont == 4 && a == 0)
        {
            Scaballo.Play();
            bien = 5;
            a = 1;
        }
        if (tiempo < 0 && !Svaca.isPlaying && fin == 0)
        {
            if (tv < 0 || tp < 0 || te < 0 || tg < 0|| tc < 0 )
            {
                if (bien1 == bien)
                {
                    visto.SetActive(true);
                    tb -= Time.deltaTime;
                }
                else
                {
                    mal.SetActive(true);
                    tb -= Time.deltaTime;
                }
                if (tb < 0)
                {
                    visto.SetActive(false);
                    mal.SetActive(false);
                    tb = 2.0f;
                    bien = 0;
                    bien1 = 0;
                    tv = 2.0f;
                    fv = 0;
                    tp = 2.0f;
                    te = 2.0f;
                    tg = 2.0f;
                    tc = 2.0f;
                    a = 0;
                    cont++;
                    if (cont == 5)
                        fin = 1;
                }
            }

        }
        if (fin == 1 && fin2 == 0)
        {
            Sapluaso.Play();
            fin2 = 1;
        }
        if (fin2 == 1 && !Sapluaso.isPlaying)
        {
            //Application.Quit();
            Application.LoadLevel("juego3.1");
        }
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
            tc -= Time.deltaTime;
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
        if (tc < 0)
        {
            bien1 = 5;
        }
    }
    public void vaca()
    {
        if (f == 1)
        {
            fv = 1;
        }
    }
    public void perro()
    {
        if (f == 1)
        {
            fv = 2;
        }
    }
    public void elefante()
    {
        if (f == 1)
        {
            fv = 3;
        }
    }
    public void gato()
    {
        if (f == 1)
        {
            fv = 4;
        }
    }
    public void caballo()
    {
        if (f == 1)
        {
            fv = 5;
        }
    }
}
