using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasos1 : MonoBehaviour {

    public Animation op1, op2, op3, op4;
    public float tiempo, t1, t2, t3, t4,t=0.0f;
    public int f, fv, a1, a2, a3, a4, cont = 0, fb = 0;
    public AudioSource check;
    public llegada llega1, llega2, llega3, llega4;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;
    
    void Start () {

        ec = "epasos1" + PlayerPrefs.GetString("nu");
        ac = "apasos1" + PlayerPrefs.GetString("nu");
        tc = "tpasos1" + PlayerPrefs.GetString("nu");

        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
     
        tiempo = 1.0f;

        f = 0;

        fv = 0;
        a1 = 0;
        a2 = 0;
        a3 = 0;
        a4 = 0;
      
    }	
	
	void Update () {

        cont = llega1.f + llega2.f + llega3.f + llega4.f;

        tiempo -= Time.deltaTime;
        t += Time.deltaTime;

        if (tiempo < 0)
        {
            f = 1;
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

        if (t1 < 0 && cont == 0&&!op2.isPlaying&& !op3.isPlaying&& !op4.isPlaying&&a1==0)
        {
            op1.Play("o1_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
        if (t2 < 0 && cont == 0 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying&&a1 == 0)
        {
            op2.Play("o2_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
        if (t3 < 0 && cont == 0 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying&&a1==0)
        {
            op3.Play("o3_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a1 = 1;
            fv = 0;
            c_aciertos++;
            
        }
        if (t4 < 0 && cont == 0 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying&&a1==0)
        {
            op4.Play("o4_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }

        if (t1 < 0 && cont == 1 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying&&a2==0)
        {
            op1.Play("o1_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a2 = 1;
            fv = 0;
            c_aciertos++;
        }
        if (t2 < 0 && cont == 1 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && a2 == 0)
        {
            op2.Play("o2_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        if (t3 < 0 && cont == 1 && !op2.isPlaying && !op1.isPlaying && !op4.isPlaying && a2 == 0)
        {
            op3.Play("o3_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 1 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && a2 == 0)
        {
            op4.Play("o4_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
            
        }

        if (t1 < 0 && cont == 2 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && a3 == 0)
        {
            op1.Play("o1_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t2 < 0 && cont == 2 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && a3 == 0)
        {
            op2.Play("o2_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t3 < 0 && cont == 2 && !op2.isPlaying && !op1.isPlaying && !op4.isPlaying && a3 == 0)
        {
            op3.Play("o3_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 2 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && a3 == 0)
        {
            op4.Play("04_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a3 = 1;
            fv = 0;
            
            c_aciertos++;
        }

        if (t1 < 0 && cont == 3 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && a4 == 0)
        {
            op1.Play("o1_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a4 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (t2 < 0 && cont == 3 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && a4 == 0)
        {
            op2.Play("o2_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a4 = 1;
            fv = 0;
            fb = 1;
            c_aciertos++;
            
        }
        if (t3 < 0 && cont == 3 && !op2.isPlaying && !op1.isPlaying && !op4.isPlaying && a4 == 0)
        {
            op3.Play("o3_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a4 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (t4 < 0 && cont == 3 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && a4 == 0)
        {
            op4.Play("04_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            a4 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (fb == 1 && !op1.isPlaying && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying)
        {
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            Application.LoadLevel("plan3");
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
