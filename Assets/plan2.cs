using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plan2 : MonoBehaviour
{
    public GameObject obj1, obj2, obj3, obj4, obj5;
    public Animation up1, up2, up3, up4, up5, down1, down2, down3, down4, down5;
    public float tiempo, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, tb, t = 0.0f;
    public int f, fv, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, fb = 0;
    public AudioSource check;
    public int c_errores = 0, c_aciertos = 0;
    public string tc, ec, ac;

    void Start()
    {
        ec = "eplan2" + PlayerPrefs.GetString("nu");
        ac = "aplan2" + PlayerPrefs.GetString("nu");
        tc = "tplan2" + PlayerPrefs.GetString("nu");

        obj1.SetActive(true);
        obj2.SetActive(false);
        obj2.SetActive(false);
        obj2.SetActive(false);
        obj2.SetActive(false);

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

        if (t1 < 0 && a1 == 0)
        {
            up1.Play("mov_up1");
            check.Play();
            a1 = 1;
            c_errores++;
        }


        if (t2 < 0 && a2 == 0)
        {
            down1.Play("mov_down1");
            check.Play();
            a2 = 1;
            c_aciertos++;
        }

        if (!up1.isPlaying && a1 == 1)
        {
            obj2.SetActive(true);
        }

        if (!down1.isPlaying && a2 == 1)
        {
            obj2.SetActive(true);
        }
        if (t3 < 0 && a3 == 0)
        {
            up2.Play("mov_up2");
            check.Play();
            a3 = 1;
            c_errores++;
        }
        if (t4 < 0 && a4 == 0)
        {
            down2.Play("mov_down2");
            check.Play();
            a4 = 1;
            c_aciertos++;
        }
        if (!up2.isPlaying && a3 == 1)
        {
            obj3.SetActive(true);
        }
        if (!down2.isPlaying && a4 == 1)
        {
            obj3.SetActive(true);
        }

        if (t5 < 0 && a5 == 0)
        {
            up3.Play("mov_up3");
            check.Play();
            a5 = 1;
            c_aciertos++;
        }
        if (t6 < 0 && a6 == 0)
        {
            down3.Play("mov_down3");
            check.Play();
            a6 = 1;
            c_errores++;
        }
        if (!up3.isPlaying && a5 == 1)
        {
            obj4.SetActive(true);
        }
        if (!down3.isPlaying && a6 == 1)
        {
            obj4.SetActive(true);
        }

        if (t7 < 0 && a7 == 0)
        {
            up4.Play("mov_up4");
            check.Play();
            a7 = 1;
            c_errores++;
        }
        if (t8 < 0 && a8 == 0)
        {
            down4.Play("mov_down4");
            check.Play();
            a8 = 1;
            c_aciertos++;
        }
        if (!up4.isPlaying && a7 == 1)
        {
            obj5.SetActive(true);
        }
        if (!down4.isPlaying && a8 == 1)
        {
            obj5.SetActive(true);
        }

        if (t9 < 0 && a9 == 0)
        {
            up5.Play("mov_up5");
            check.Play();
            a9 = 1;
            fb = 1;
            c_aciertos++;
        }
        if (t10 < 0 && a10 == 0)
        {
            down5.Play("mov_down5");
            check.Play();
            a10 = 1;
            fb = 1;
            c_errores++;
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
}