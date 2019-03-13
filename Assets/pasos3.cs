using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasos3 : MonoBehaviour
{
    
    public Animation op1, op2, op3, op4, op5, op6;
    public float tiempo, t1, t2, t3, t4, t5, t6, t = 0.0f;
    public int f, fv, a1, a2, a3, a4, a5, a6, cont = 0, fb = 0;
    public AudioSource check;
    public llegada llega1, llega2, llega3, llega4, llega5, llega6;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;

    void Start()
    {
        ec = "epasos2" + PlayerPrefs.GetString("nu");
        ac = "apasos2" + PlayerPrefs.GetString("nu");
        tc = "tpasos2" + PlayerPrefs.GetString("nu");

        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        t5 = 2.0f;
        t6 = 2.0f;
   
        tiempo = 2.0f;

        f = 0;
        fv = 0;
        a1 = 0;
        a2 = 0;
        a3 = 0;
        a4 = 0;
        a5 = 0;
        a6 = 0;
    }

    void Update()
    {
        cont = llega1.f + llega2.f + llega3.f + llega4.f + llega5.f + llega6.f;

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
        if (fv == 5)
        {
            t5 -= Time.deltaTime;
        }
        if (fv == 6)
        {
            t6 -= Time.deltaTime;
        }
       
        if (t1 < 0 && cont == 0 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a1 == 0)
        {
            op1.Play("a1_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
        if (t2 < 0 && cont == 0 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a1 == 0)
        {
            op2.Play("a2_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
        if (t3 < 0 && cont == 0 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a1 == 0)
        {
            op3.Play("a3_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 0 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op6.isPlaying && a1 == 0)
        {
            op4.Play("a4_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
        if (t5 < 0 && cont == 0 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op4.isPlaying && !op6.isPlaying && a1 == 0)
        {
            op5.Play("a5_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a1 = 1;
            fv = 0;
            c_aciertos++;
           
        }
        if (t6 < 0 && cont == 0 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op4.isPlaying && a1 == 0)
        {
            op6.Play("a6_1");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a1 = 1;
            fv = 0;
            c_errores++;
        }
       
        if (t1 < 0 && cont == 1 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a2 == 0)
        {
            op1.Play("a1_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        if (t2 < 0 && cont == 1 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a2 == 0)
        {
            op2.Play("a2_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a2 = 1;
            fv = 0;
            c_aciertos++;
        }
        if (t3 < 0 && cont == 1 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a2 == 0)
        {
            op3.Play("a3_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 1 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op6.isPlaying && a2 == 0)
        {
            op4.Play("a4_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        if (t5 < 0 && cont == 1 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op4.isPlaying && !op6.isPlaying && a2 == 0)
        {
            op5.Play("a5_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        if (t6 < 0 && cont == 1 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op4.isPlaying && a2 == 0)
        {
            op6.Play("a6_2");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a2 = 1;
            fv = 0;
            c_errores++;
        }
        
        if (t1 < 0 && cont == 2 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a3 == 0)
        {
            op1.Play("a1_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t2 < 0 && cont == 2 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a3 == 0)
        {
            op2.Play("a2_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t3 < 0 && cont == 2 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a3 == 0)
        {
            op3.Play("a3_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 2 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op6.isPlaying && a3 == 0)
        {
            op4.Play("a4_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t5 < 0 && cont == 2 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op4.isPlaying && !op6.isPlaying && a3 == 0)
        {
            op5.Play("a5_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a3 = 1;
            fv = 0;
            c_errores++;
        }
        if (t6 < 0 && cont == 2 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op4.isPlaying && a3 == 0)
        {
            op6.Play("a6_3");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a3 = 1;
            fv = 0;
            c_aciertos++;
        }
        
        if (t1 < 0 && cont == 3 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a4 == 0)
        {
            op1.Play("a1_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a4 = 1;
            fv = 0;
            c_aciertos++;
        }
        if (t2 < 0 && cont == 3 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a4 == 0)
        {
            op2.Play("a2_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a4 = 1;
            fv = 0;
            c_errores++;

        }
        if (t3 < 0 && cont == 3 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a4 == 0)
        {
            op3.Play("a3_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a4 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 3 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op6.isPlaying && a4 == 0)
        {
            op4.Play("a4_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a4 = 1;
            fv = 0;
            c_errores++;
        }
        if (t5 < 0 && cont == 3 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op4.isPlaying && !op6.isPlaying && a4 == 0)
        {
            op5.Play("a5_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a4 = 1;
            fv = 0;
            c_errores++;
        }
        if (t6 < 0 && cont == 3 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op4.isPlaying && a4 == 0)
        {
            op6.Play("a6_4");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a4 = 1;
            fv = 0;
            c_errores++;
        }
        
        if (t1 < 0 && cont == 4 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a5 == 0)
        {
            op1.Play("a1_5");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a5 = 1;
            fv = 0;
            c_errores++;
        }
        if (t2 < 0 && cont == 4 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a5 == 0)
        {
            op2.Play("a2_5");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a5 = 1;
            fv = 0;
            c_errores++;
        }
        if (t3 < 0 && cont == 4 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a5 == 0)
        {
            op3.Play("a3_5");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a5 = 1;
            fv = 0;
            c_errores++;
        }
        if (t4 < 0 && cont == 4 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op6.isPlaying && a5 == 0)
        {
            op4.Play("a4_5");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a5 = 1;
            fv = 0;
            c_aciertos++;
        }
        if (t5 < 0 && cont == 4 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op4.isPlaying && !op6.isPlaying && a5 == 0)
        {
            op5.Play("a5_5");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a5 = 1;
            fv = 0;
            c_errores++;
        }
        if (t6 < 0 && cont == 4 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op4.isPlaying && a5 == 0)
        {
            op6.Play("a6_5");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a5 = 1;
            fv = 0;
            c_errores++;
        }
        
        if (t1 < 0 && cont == 5 && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a6 == 0)
        {
            op1.Play("a1_6");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a6 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (t2 < 0 && cont == 5 && !op1.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a6 == 0)
        {
            op2.Play("a2_6");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a6 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (t3 < 0 && cont == 5 && !op1.isPlaying && !op2.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying && a6 == 0)
        {
            op3.Play("a3_6");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a6 = 1;
            fv = 0;
            fb = 1;
            c_aciertos++;
        }
        if (t4 < 0 && cont == 5 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op6.isPlaying && a6 == 0)
        {
            op4.Play("a4_6");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a6 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (t5 < 0 && cont == 5 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op4.isPlaying && !op6.isPlaying && a6 == 0)
        {
            op5.Play("a5_6");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a6 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (t6 < 0 && cont == 5 && !op2.isPlaying && !op3.isPlaying && !op1.isPlaying && !op5.isPlaying && !op4.isPlaying && a6 == 0)
        {
            op6.Play("a6_6");
            t1 = 2.0f;
            t2 = 2.0f;
            t3 = 2.0f;
            t4 = 2.0f;
            t5 = 2.0f;
            t6 = 2.0f;
            a6 = 1;
            fv = 0;
            fb = 1;
            c_errores++;
        }
        if (fb == 1 && !op1.isPlaying && !op2.isPlaying && !op3.isPlaying && !op4.isPlaying && !op5.isPlaying && !op6.isPlaying )
        {
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            Application.LoadLevel("plan2");
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
    public void fuera()
    {
        t1 = 2.0f;
        t2 = 2.0f;
        t3 = 2.0f;
        t4 = 2.0f;
        t5 = 2.0f;
        t6 = 2.0f;
        fv = 0;
        //fb = 1;
    }
}