using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animales1 : MonoBehaviour {

    public AudioSource Svaca, Sperro, Selefante, Sgato,Sapluaso;
    public float tv, tiempo, tb, tp, te, tg;
    public GameObject aviso,visto, mal,puntero;
    public int f, fv, bien, bien1, a=0, cont=0,fin=0,fin2=0;

	void Start () {
        tv = 2.0f;
        te = 2.0f;
        tp = 2.0f;
        tg = 2.0f; 
        tiempo = 5.0f;
        f = 0;
        fv = 0;
        puntero.SetActive(false);
        aviso.SetActive(true);
        visto.SetActive(false);
        mal.SetActive(false);
        bien = 0;
        bien1 = 0;
        tb = 2.0f;
	}
	
	void Update () {

        tiempo -= Time.deltaTime;

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
        if (tiempo < 0)
        {
            f = 1;
            aviso.SetActive(false);
        }
        if (f == 1&&a==0&&cont==0)
        {
            puntero.SetActive(false);
            Svaca.Play();
            bien = 1;
            a = 1;
        }
        if (f == 1 && cont == 1&& a ==0)
        {
            puntero.SetActive(false);
            Sperro.Play();
            bien = 2;
            a = 1;
        }
        if (f == 1 && cont == 2 && a == 0)
        {
            puntero.SetActive(false);
            Selefante.Play();
            bien = 3;
            a = 1;
        }
        if (f == 1 && cont == 3 && a == 0)
        {
            puntero.SetActive(false);
            Sgato.Play();
            bien = 4;
            a = 1;
        }
        if (tiempo < 0 && !Svaca.isPlaying && fin==0)
        {
            if (tv < 0 || tp < 0 || te < 0|| tg<0 )
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
                    a = 0;
                    cont++;
                    if (cont == 4)
                        fin = 1;
                }
            }
            
        }
        if (fin == 1&&fin2==0)
        {
            Sapluaso.Play();
            fin2 = 1;
        }
        if (fin2 == 1 && !Sapluaso.isPlaying)
        {
            Application.LoadLevel("juego3.1");
        }
        
    }
    public void vaca()
    {
        if (f == 1&&!Svaca.isPlaying&&!Sgato.isPlaying&&!Selefante.isPlaying&&!Sperro.isPlaying)
        {
            fv = 1;
            puntero.SetActive(true);
        }
    }
    public void perro()
    {
        if (f == 1 && !Svaca.isPlaying && !Sgato.isPlaying && !Selefante.isPlaying && !Sperro.isPlaying)
        {
            fv = 2;
            puntero.SetActive(true);
        }
    }
    public void elefante()
    {
        if (f == 1 && !Svaca.isPlaying && !Sgato.isPlaying && !Selefante.isPlaying && !Sperro.isPlaying)
        {
            fv = 3;
            puntero.SetActive(true);
        }
    }
    public void gato()
    {
        if (f == 1 && !Svaca.isPlaying && !Sgato.isPlaying && !Selefante.isPlaying && !Sperro.isPlaying)
        {
            fv = 4;
            puntero.SetActive(true);
        }
    }
}
