using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plan3 : MonoBehaviour {

    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9;
    public Animation unod, unoa, unoc, dosd, dosa, dosc, tresd, tresa, tresc, cuatroa, cuatrod, cuatroc, cincoa, cincod, cincoc, seisa, seisd, seisc, sietea, sietec, sieted, ochoa, ochoc, ochod, nuevea, nuevec, nueved;
    public float tiempo, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, tb, t = 0.0f;
    public int f, fv, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, fb = 0;
    public AudioSource check;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;

    void Start()
    {
        ec = "eplan3" + PlayerPrefs.GetString("nu");
        ac = "aplan3" + PlayerPrefs.GetString("nu");
        tc = "tplan3" + PlayerPrefs.GetString("nu");

        obj1.SetActive(true);
        obj2.SetActive(false);
        obj3.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(false);
        obj7.SetActive(false);
        obj8.SetActive(false);
        obj9.SetActive(false);

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
        t14 = 2.0f;
        t15 = 2.0f;
        t16 = 2.0f;
        t17 = 2.0f;
        t18 = 2.0f;
        t19 = 2.0f;
        t20 = 2.0f;
        t21 = 2.0f;
        t22 = 2.0f;
        t23 = 2.0f;
        t24 = 2.0f;
        t25 = 2.0f;
        t26 = 2.0f;
        t27 = 2.0f;


        tiempo = 2.0f;

        f = 0;
        fv = 0;
        a1 = 0;
        a2 = 0;
        a3 = 0;
        a4 = 0;
        a5 = 0;
        a6 = 0;
        a7 = 0;
        a8 = 0;
        a9 = 0;
        a10 = 0;
        a11 = 0;
        a12 = 0;
        a13 = 0;
        a14 = 0;
        a15 = 0;
        a16 = 0;
        a17 = 0;
        a18 = 0;
        a19 = 0;
        a20 = 0;
        a21 = 0;
        a22 = 0;
        a23 = 0;
        a24 = 0;
        a25 = 0;
        a26 = 0;
        a27 = 0;

        tb = 1.0f;
    }

    void Update()
    {
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
        if (fv == 23)
        {
            t23 -= Time.deltaTime;
        }
        if (fv == 24)
        {
            t24 -= Time.deltaTime;
        }
        if (fv == 25)
        {
            t25 -= Time.deltaTime;
        }
        if (fv == 26)
        {
            t26 -= Time.deltaTime;
        }
        if (fv == 27)
        {
            t27 -= Time.deltaTime;
        }

        if (t1 < 0 && a1 == 0)
        {
            unoa.Play("uno_a");
            check.Play();
            a1 = 1;
            c_aciertos++;
        }

        if (t2 < 0 && a2 == 0)
        {
            unoc.Play("uno_c");
            check.Play();
            a2 = 1;
            c_errores++;
        }

        if (t3 < 0 && a3 == 0)
        {
            unod.Play("uno_d");
            check.Play();
            a3 = 1;
            c_errores++;
        }

        if (!unoa.isPlaying && a1 == 1)
        {
            obj2.SetActive(true);
        }

        if (!unoc.isPlaying && a2 == 1)
        {
            obj2.SetActive(true);
        }

        if (!unod.isPlaying && a3 == 1)
        {
            obj2.SetActive(true);
        }
        if (t4 < 0 && a4 == 0)
        {
            dosa.Play("dos_a");
            check.Play();
            a4 = 1;
            c_errores++;
        }
        if (t5 < 0 && a5 == 0)
        {
            dosc.Play("dos_c");
            check.Play();
            a5 = 1;
            c_errores++;
        }
        if (t6 < 0 && a6 == 0)
        {
            dosd.Play("dos_d");
            check.Play();
            a6 = 1;
            c_aciertos++;
        }
        if (!dosa.isPlaying && a4 == 1)
        {
            obj3.SetActive(true);
        }
        if (!dosc.isPlaying && a5 == 1)
        {
            obj3.SetActive(true);
        }
        if (!dosd.isPlaying && a6 == 1)
        {
            obj3.SetActive(true);
        }

        if (t7 < 0 && a7 == 0)
        {
            tresa.Play("tres_a");
            check.Play();
            a7 = 1;
            c_aciertos++;
        }
        if (t8 < 0 && a8 == 0)
        {
            tresc.Play("tres_c");
            check.Play();
            a8 = 1;
            c_errores++;
        }
        if (t9 < 0 && a9 == 0)
        {
            tresd.Play("tres_d");
            check.Play();
            a9 = 1;
            c_errores++;
        }

        if (!tresa.isPlaying && a7 == 1)
        {
            obj4.SetActive(true);
        }
        if (!tresc.isPlaying && a8 == 1)
        {
            obj4.SetActive(true);
        }
        if (!tresd.isPlaying && a9 == 1)
        {
            obj4.SetActive(true);
        }
        if (t10 < 0 && a10 == 0)
        {
            cuatroa.Play("cuatro_a");
            check.Play();
            a10 = 1;
            c_errores++;
        }
        if (t11 < 0 && a11 == 0)
        {
            cuatroc.Play("cuatro_c");
            check.Play();
            a11 = 1;
            c_aciertos++;
        }
        if (t12 < 0 && a12 == 0)
        {
            cuatrod.Play("cuatro_d");
            check.Play();
            a12 = 1;
            c_errores++;
        }
        if (!cuatroa.isPlaying && a10 == 1)
        {
            obj5.SetActive(true);
        }
        if (!cuatroc.isPlaying && a11 == 1)
        {
            obj5.SetActive(true);
        }
        if (!cuatrod.isPlaying && a12 == 1)
        {
            obj5.SetActive(true);
        }
        if (t13 < 0 && a13 == 0)
        {
            cincoa.Play("cinco_a");
            check.Play();
            a13 = 1;
            c_aciertos++;
        }
        if (t14 < 0 && a14 == 0)
        {
            cincoc.Play("cinco_c");
            check.Play();
            a14 = 1;
            c_errores++;
        }
        if (t15 < 0 && a15 == 0)
        {
            cincod.Play("cinco_d");
            check.Play();
            a15 = 1;
            c_errores++;
        }
        if (!cincoa.isPlaying && a13 == 1)
        {
            obj6.SetActive(true);
        }
        if (!cincoc.isPlaying && a14 == 1)
        {
            obj6.SetActive(true);
        }
        if (!cincod.isPlaying && a15 == 1)
        {
            obj6.SetActive(true);
        }
        if (t16 < 0 && a16 == 0)
        {
            seisa.Play("seis_a");
            check.Play();
            a16 = 1;
            c_errores++;
        }
        if (t17 < 0 && a17 == 0)
        {
            seisc.Play("seis_d");
            check.Play();
            a17 = 1;
            c_errores++;
        }
        if (t18 < 0 && a18 == 0)
        {
            seisd.Play("seis_c");
            check.Play();
            a18 = 1;
            c_aciertos++;
            
        }
        if (!seisa.isPlaying && a16 == 1)
        {
            obj7.SetActive(true);
        }
        if (!seisd.isPlaying && a17 == 1)
        {
            obj7.SetActive(true);
        }
        if (!seisc.isPlaying && a18 == 1)
        {
            obj7.SetActive(true);
        }
        if (t19 < 0 && a19 == 0)
        {
            sietea.Play("siete_a");
            check.Play();
            a19 = 1;
            c_errores++;
        }
        if (t20 < 0 && a20 == 0)
        {
            sietec.Play("siete_c");
            check.Play();
            a20 = 1;
            c_aciertos++;
        }
        if (t21 < 0 && a21 == 0)
        {
            sieted.Play("siete_d");
            check.Play();
            a21 = 1;
            c_errores++;
        }
        if (!sietea.isPlaying && a19 == 1)
        {
            obj8.SetActive(true);
        }
        if (!sietec.isPlaying && a20 == 1)
        {
            obj8.SetActive(true);
        }
        if (!sieted.isPlaying && a21 == 1)
        {
            obj8.SetActive(true);
        }
        if (t22 < 0 && a22 == 0)
        {
            ochoa.Play("ocho_a");
            check.Play();
            a22 = 1;
            c_errores++;
        }
        if (t23 < 0 && a23 == 0)
        {
            ochoc.Play("ocho_c");
            check.Play();
            a23 = 1;
            c_aciertos++;
        }
        if (t24 < 0 && a24 == 0)
        {
            ochod.Play("ocho_d");
            check.Play();
            a24 = 1;
            c_errores++;
        }
        if (!ochoa.isPlaying && a22 == 1)
        {
            obj9.SetActive(true);
        }
        if (!ochoc.isPlaying && a23 == 1)
        {
            obj9.SetActive(true);
        }
        if (!ochod.isPlaying && a24 == 1)
        {
            obj9.SetActive(true);
        }
        if (t25 < 0 && a25 == 0)
        {
            nuevea.Play("nueve_a");
            check.Play();
            a25 = 1;
            fb = 1;
            c_errores++;
        }
        if (t26 < 0 && a26 == 0)
        {
            nuevec.Play("nueve_c");
            check.Play();
            a26 = 1;
            fb = 1;
            c_errores++;
        }
        if (t27 < 0 && a27 == 0)
        {
            nueved.Play("nueve_d");
            check.Play();
            a27 = 1;
            fb = 1;
            c_aciertos++;
        }
        if (fb == 1)
        {
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            Application.LoadLevel("resultados");
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
    public void objeto17()
    {
        if (f == 1)
        {
            fv = 17;

        }
    }
    public void objeto18()
    {
        if (f == 1)
        {
            fv = 18;

        }
    }
    public void objeto19()
    {
        if (f == 1)
        {
            fv = 19;

        }
    }
    public void objeto20()
    {
        if (f == 1)
        {
            fv = 20;

        }
    }
    public void objeto21()
    {
        if (f == 1)
        {
            fv = 21;

        }
    }
    public void objeto22()
    {
        if (f == 1)
        {
            fv = 22;

        }
    }
    public void objeto23()
    {
        if (f == 1)
        {
            fv = 23;

        }
    }
    public void objeto24()
    {
        if (f == 1)
        {
            fv = 24;

        }
    }
    public void objeto25()
    {
        if (f == 1)
        {
            fv = 25;

        }
    }
    public void objeto26()
    {
        if (f == 1)
        {
            fv = 26;

        }
    }
    public void objeto27()
    {
        if (f == 1)
        {
            fv = 27;

        }
    }

}
