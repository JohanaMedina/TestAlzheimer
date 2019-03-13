using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animales : MonoBehaviour {

    // public GameObject vaca1, elefante1, gato1, perro1, aviso;
    public GameObject aviso, visto, error;
    float tv, te, tg, tp, tbien, tiempo=5.0f;
    public int fv, fe, fg, fp, audioOn, audioOff, fv1, fe1, fg1, fp1, fv2, fe2, fg2, fp2, bien=0, bien1=0;
    public AudioSource soundV, soundE, soundG, soundP;


	// Use this for initialization
	void Start () {
        aviso.SetActive(true);
        visto.SetActive(false);
        error.SetActive(false);
        tv = 5.0f;
        te = 5.0f;
        tg = 5.0f;
        tp = 5.0f;
        tbien = 2.0f;
        fv = 0;
        fe = 0;
        fg = 0;
        fp = 0;
        fv1 = 0;
        fe1 = 0;
        fg1 = 0;
        fp1 = 0;
        fv2 = 0;
        fe2 = 0;
        fg2 = 0;
        fp2 = 0;
        audioOn = 0;
        audioOff = 0;
	}

    // Update is called once per frame
    void Update() {
        tiempo -= Time.deltaTime;

        if (fv2 == 1)
        {
            tv -= Time.deltaTime;
        }
        if (fp2 == 1)
        {
            tp -= Time.deltaTime;
        }
        if (fe2 == 1)
        {
            te -= Time.deltaTime;
        }
        if (fg2 == 1)
        {
            tg -= Time.deltaTime;
        }
        if (tv < 0 && fv2 == 1)
        {
            bien = 1;
            fv1 = 1;          
        }
        if (tp < 0 && fp2 == 1)
        {
            bien = 2;
            fp1 = 1;
        }
        if (tg < 0 && fg2 == 1)
        {
            bien = 3;
            fg1 = 1;
        }
        if (te < 0 && fe2 == 1)
        {
            bien = 4;
            fe1 = 1;
        }
        if (tiempo < 0)
        {
            if (fv2 != 0 || fg2 != 0 || fp2 != 0 || fe2 != 0)
            {
                if (bien == bien1)
                {
                    visto.SetActive(true);
                    tbien -= Time.deltaTime;
                }
                else
                {
                    error.SetActive(true);
                    tbien -= Time.deltaTime;
                }

            }

            if (tbien < 0)
            {
                visto.SetActive(false);
                error.SetActive(false);
                bien = 0;
                bien1 = 0;
                tbien = 2.0f;
                fv2 = 0;
                fe2 = 0;
                fp2 = 0;
                fg2 = 0;
                fv1 = 0;
                fe1 = 0;
                fp1 = 0;
                fg1 = 0;
                tv = 2.0f;
                tp = 2.0f;
                tg = 2.0f;
                te = 2.0f;
            }
        }
        

        if (tiempo < 0&& fv==0)
        {
            aviso.SetActive(false);
            soundV.Play();
            fv = 1;
                bien1 = 1;
        }
        if (fv == 1 && fg==0 && !soundV.isPlaying && te < 0 && tg < 0 && tp < 0)
        {
            soundG.Play();
            fg = 1;
            bien1 = 2;
        }
        if (fg == 1 && fp==0 && !soundG.isPlaying && te < 0 && tg < 0 && tp < 0)
        {
            soundP.Play();
            fp = 1;
            bien1 = 3;
        }
        if (fp == 1 && fe==0 && !soundP.isPlaying && te < 0 && tg < 0 && tp < 0)
        {
            soundE.Play();
            fe = 1;
            bien1 = 4;
        }
	}
    public void vaca ()
    {
        tv = 5.0f;
        if (fv1 == 0)
        {
            fv2 = 1;
        }        
    }
    public void gato()
    {
        tg = 5.0f;
        if (fg1 == 0)
        {
            fg2 = 1;
        }
    }
    public void perro()
    {
        tp= 5.0f;
        if (fp1 == 0)
        {
            fp2 = 1;
        }
    }
    public void elefante()
    {
        te = 5.0f;
        if (fe1 == 0)
        {
            fe2 = 1;
        }
    }
}
