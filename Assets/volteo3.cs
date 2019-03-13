﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volteo3: MonoBehaviour
{
    public Animation Up1, Up2, Up3, Up4, Up5, Up6, Up7, Up8, Up9, Up10, Up11, Up12, Down1, Down2, Down3, Down4, Down5, Down6, Down7, Down8, Down9, Down10, Down11, Down12;
    public GameObject felicitaciones, pr1, pr2, pc1, pc2, pe1, pe2, pp1, pp2, pg1, pg2, ppa1, ppa2;
    public int volteo1, voltear2, count = 0, cr, cp, cc, ce, cg, cpa, b = 0;
    public int sr1 = 0, sr2 = 0, sc1 = 0, sc2 = 0, se1 = 0, se2 = 0, sp1 = 0, sp2 = 0, sg1 = 0, sg2 = 0, spa1 = 0, spa2 = 0;
    public int contr1, contr2, contp1, contp2, conte1, conte2, contc1, contc2, contg1, contg2, contpa1, contpa2;
    public int aux = 0, fr1 = 0, fr2 = 0, fe1 = 0, fe2 = 0, fp1 = 0, fp2 = 0, fc1 = 0, fc2 = 0, fg1 = 0, fg2 = 0, fpa1 = 0, fpa2 = 0;
    public float tr1, tr2, tc1, tc2, te1, te2, tp1, tp2, tg1, tg2, tpa1, tpa2, t = 0.0f;
    public AudioSource vuelta, acierto, final, final2, mal;
    public int c_errores = 0, c_aciertos = 0, f = 0;
    public string tc, ec, ac;

    void Start()
    {
        ec = "ecartas2" + PlayerPrefs.GetString("nu");
        ac = "acartas2" + PlayerPrefs.GetString("nu");
        tc = "tcartas2" + PlayerPrefs.GetString("nu");

        pr1.SetActive(false);
        pr2.SetActive(false);
        pc1.SetActive(false);
        pc2.SetActive(false);
        pe1.SetActive(false);
        pe2.SetActive(false);
        pp1.SetActive(false);
        pp2.SetActive(false);
        pg1.SetActive(false);
        pg2.SetActive(false);
        ppa1.SetActive(false);
        ppa2.SetActive(false);

        volteo1 = 0;
        voltear2 = 0;
        felicitaciones.SetActive(false);
        tr1 = 2.0f;
        tr2 = 2.0f;
        tc1 = 2.0f;
        tc2 = 2.0f;
        te1 = 2.0f;
        te2 = 2.0f;
        tp1 = 2.0f;
        tp2 = 2.0f;
        tg1 = 2.0f;
        tg2 = 2.0f;
        tpa1 = 2.0f;
        tpa2 = 2.0f;

        cp = 0;
        cr = 0;
        ce = 0;
        cc = 0;
        cg = 0;
        cpa = 0;

        contr1 = 0;
        contr2 = 0;
        contp1 = 0;
        contp2 = 0;
        conte1 = 0;
        conte2 = 0;
        contc1 = 0;
        contc2 = 0;
        contg1 = 0;
        contg2 = 0;
        contpa1 = 0;
        contpa2 = 0;
    }

    void Update()
    {
        t += Time.deltaTime;
        aux = contr1 + contr2 + contp1 + contp2 + conte1 + conte2 + contc1 + contc2 + contg1 + contg2 + contpa1 + contpa2;
        count = ce + cc + cp + cr + cg + cpa;

        if (fc1 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tc1 -= Time.deltaTime;
        }
        if (fr1 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tr1 -= Time.deltaTime;
        }
        if (fc2 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tc2 -= Time.deltaTime;
        }
        if (fr2 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tr2 -= Time.deltaTime;
        }
        if (fp1 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tp1 -= Time.deltaTime;
        }
        if (fp2 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tp2 -= Time.deltaTime;
        }
        if (fe1 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            te1 -= Time.deltaTime;
        }
        if (fe2 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            te2 -= Time.deltaTime;
        }
        if (fg1 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tg1 -= Time.deltaTime;
        }
        if (fg2 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tg2 -= Time.deltaTime;
        }
        if (fpa1 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tpa1 -= Time.deltaTime;
        }
        if (fpa2 == 1 && !Down1.isPlaying && !Down2.isPlaying && !Down5.isPlaying && !Down4.isPlaying && !Down8.isPlaying && !Down3.isPlaying && !Down6.isPlaying && !Down7.isPlaying && !Down9.isPlaying && !Down10.isPlaying && !Down11.isPlaying && !Down12.isPlaying)
        {
            tpa2 -= Time.deltaTime;
        }

        if (tc1 <= 0 && sc1 == 0)
        {
            Up1.Play();
            vuelta.Play();
            contc1 = 1;
            sc1 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tr1 <= 0 && sr1 == 0)
        {
            Up2.Play();
            vuelta.Play();
            contr1 = 1;
            sr1 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tr2 <= 0 && sr2 == 0)
        {
            Up6.Play();
            vuelta.Play();
            contr2 = 1;
            sr2 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tc2 <= 0 && sc2 == 0)
        {
            Up9.Play();
            vuelta.Play();
            contc2 = 1;
            sc2 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tp2 <= 0 && sp2 == 0)
        {
            Up11.Play();
            vuelta.Play();
            contp2 = 1;
            sp2 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tp1 <= 0 && sp1 == 0)
        {
            Up4.Play();
            vuelta.Play();
            contp1 = 1;
            sp1 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (te2 <= 0 && se2 == 0)
        {
            Up12.Play();
            vuelta.Play();
            conte2 = 1;
            se2 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (te1 <= 0 && se1 == 0)
        {
            Up3.Play();
            vuelta.Play();
            conte1 = 1;
            se1 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tg1 <= 0 && sg1 == 0)
        {
            Up5.Play();
            vuelta.Play();
            contg1 = 1;
            sg1 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tg2 <= 0 && sg2 == 0)
        {
            Up10.Play();
            vuelta.Play();
            contg2 = 1;
            sg2 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tpa1 <= 0 && spa1 == 0)
        {
            Up7.Play();
            vuelta.Play();
            contpa1 = 1;
            spa1 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }
        if (tpa2 <= 0 && spa2 == 0)
        {
            Up8.Play();
            vuelta.Play();
            contpa2 = 1;
            spa2 = 1;
            if (volteo1 == 1)
            {
                voltear2 = 1;
            }
            volteo1 = 1;
        }

        if (volteo1 == 1 && voltear2 == 1 && aux == 2 && !Up1.isPlaying && !Up2.isPlaying && !Up5.isPlaying && !Up4.isPlaying && !Up8.isPlaying && !Up3.isPlaying && !Up6.isPlaying && !Up7.isPlaying && !Up9.isPlaying && !Up10.isPlaying && !Up11.isPlaying && !Up12.isPlaying)
        {
            if (contr1 == 1 && contr2 == 0)
            {
                carta2Down();
                volteo1 = 0;
                voltear2 = 0;
                sr1 = 0;
                contr1 = 0;
                mal.Play();
                c_errores++;

            }
            if (contr1 == 0 && contr2 == 1)
            {
                carta6Down();
                volteo1 = 0;
                voltear2 = 0;
                sr2 = 0;
                contr2 = 0;
                mal.Play();
                c_errores++;

            }
            if (contr1 == 1 && contr2 == 1)
            {
                volteo1 = 0;
                voltear2 = 0;
                cr = 1;
                contr1 = 0;
                contr2 = 0;
                acierto.Play();
                pr1.SetActive(true);
                pr2.SetActive(true);
                c_aciertos++;
            }
            if (contc1 == 1 && contc2 == 0)
            {
                carta1Down();
                volteo1 = 0;
                voltear2 = 0;
                sc1 = 0;
                contc1 = 0;
                mal.Play();
                c_errores++;
            }
            if (contc1 == 0 && contc2 == 1)
            {
                carta9Down();
                volteo1 = 0;
                voltear2 = 0;
                sc2 = 0;
                contc2 = 0;
                mal.Play();
                c_errores++;
            }
            if (contc1 == 1 && contc2 == 1)
            {
                volteo1 = 0;
                voltear2 = 0;
                cc = 1;
                contc1 = 0;
                contc2 = 0;
                acierto.Play();
                pc1.SetActive(true);
                pc2.SetActive(true);
                c_aciertos++;
            }
            if (contp1 == 1 && contp2 == 0)
            {
                carta4Down();
                volteo1 = 0;
                voltear2 = 0;
                sp1 = 0;
                contp1 = 0;
                mal.Play();
                c_errores++;
            }
            if (contp1 == 0 && contp2 == 1)
            {
                carta11Down();
                volteo1 = 0;
                voltear2 = 0;
                sp2 = 0;
                contp2 = 0;
                mal.Play();
                c_errores++;
            }
            if (contp1 == 1 && contp2 == 1)
            {
                volteo1 = 0;
                voltear2 = 0;
                cp = 1;
                contp1 = 0;
                contp2 = 0;
                acierto.Play();
                pp1.SetActive(true);
                pp2.SetActive(true);
                c_aciertos++;
            }
            if (conte1 == 1 && conte2 == 0)
            {
                carta3Down();
                volteo1 = 0;
                voltear2 = 0;
                se1 = 0;
                conte1 = 0;
                mal.Play();
                c_errores++;
            }
            if (conte1 == 0 && conte2 == 1)
            {
                carta12Down();
                volteo1 = 0;
                voltear2 = 0;
                se2 = 0;
                conte2 = 0;
                mal.Play();
                c_errores++;
            }
            if (conte1 == 1 && conte2 == 1)
            {
                volteo1 = 0;
                voltear2 = 0;
                ce = 1;
                conte1 = 0;
                conte2 = 0;
                acierto.Play();
                pe1.SetActive(true);
                pe2.SetActive(true);
                c_aciertos++;
            }
            if (contg1 == 1 && contg2 == 0)
            {
                carta5Down();
                volteo1 = 0;
                voltear2 = 0;
                sg1 = 0;
                contg1 = 0;
                mal.Play();
                c_errores++;
            }
            if (contg1 == 0 && contg2 == 1)
            {
                carta10Down();
                volteo1 = 0;
                voltear2 = 0;
                sg2 = 0;
                contg2 = 0;
                mal.Play();
                c_errores++;
            }
            if (contg1 == 1 && contg2 == 1)
            {
                volteo1 = 0;
                voltear2 = 0;
                cg = 1;
                contg1 = 0;
                contg2 = 0;
                acierto.Play();
                pg1.SetActive(true);
                pg2.SetActive(true);
                c_aciertos++;
            }
            if (contpa1 == 1 && contpa2 == 0)
            {
                carta7Down();
                volteo1 = 0;
                voltear2 = 0;
                spa1 = 0;
                contpa1 = 0;
                mal.Play();
                c_errores++;
            }
            if (contpa1 == 0 && contpa2 == 1)
            {
                carta8Down();
                volteo1 = 0;
                voltear2 = 0;
                spa2 = 0;
                contpa2 = 0;
                mal.Play();
                c_errores++;
            }
            if (contpa1 == 1 && contpa2 == 1)
            {
                volteo1 = 0;
                voltear2 = 0;
                cpa = 1;
                contpa1 = 0;
                contpa2 = 0;
                acierto.Play();
                ppa1.SetActive(true);
                ppa2.SetActive(true);
                c_aciertos++;
            }

            aux = 0;

        }
        if (count == 6)
        {
            count = 0;
            cc = 0;
            b = 1;
        }

        if (b == 1)
        {
            if (f == 0 && c_errores != 0)
            {
                c_errores = c_errores / 2;
                f = 1;
            }

            PlayerPrefs.SetString(tc, t.ToString("f0"));
            PlayerPrefs.SetString(ec, c_errores.ToString());
            PlayerPrefs.SetString(ac, c_aciertos.ToString());
            //Application.LoadLevel("secuencias7");
        }
    }
    public void carta1Up()
    {
        tc1 = 2.0f;
        if (sc1 == 0)
        {
            fc1 = 1;
        }
    }
    public void carta2Up()
    {
        tr1 = 2.0f;
        if (sr1 == 0)
        {
            fr1 = 1;         
        }
    }
    public void carta3Up()
    {
        te1 = 2.0f;
        if (se1 == 0)
        {
            fe1 = 1;
        }
    }
    public void carta4Up()
    {
        tp1 = 2.0f;
        if (sp1 == 0)
        {
            fp1 = 1;
        }
    }
    public void carta5Up()
    {
        tg1 = 2.0f;

        if (sg1 == 0)
        {
            fg1 = 1;
        }
    }
    public void carta6Up()
    {
        tr2 = 2.0f;
        if (sr2 == 0)
        {
            fr2 = 1;
        }
    }
    public void carta7Up()
    {
        tpa1 = 2.0f;
        if (spa1 == 0)
        {
            fpa1 = 1;
        }
    }
    public void carta8Up()
    {
        tpa2 = 2.0f;
        if (spa2 == 0)
        {
            fpa2 = 1;
        }
    }
    public void carta9Up()
    {
        tc2 = 2.0f;
        if (sc2 == 0)
        {
            fc2 = 1;
        }
    }
    public void carta10Up()
    {
        tg2 = 2.0f;
        if (sg2 == 0)
        {
            fg2 = 1;
        }
    }
    public void carta11Up()
    {
        tp2 = 2.0f;
        if (sp2 == 0)
        {
            fp2 = 1;
        }
    }
    public void carta12Up()
    {
        te2 = 2.0f;
        if (se2 == 0)
        {
            fe2 = 1;
        }
    }

    public void carta1Down()
    {
        Down1.Play("FlipDown");
    }
    public void carta2Down()
    {
        Down2.Play("FlipDown");
    }
    public void carta3Down()
    {
        Down3.Play("FlipDown");
    }
    public void carta4Down()
    {
        Down4.Play("FlipDown");
    }
    public void carta5Down()
    {
        Down5.Play("FlipDown");
    }
    public void carta6Down()
    {
        Down6.Play("FlipDown");
    }
    public void carta7Down()
    {
        Down7.Play("FlipDown");
    }
    public void carta8Down()
    {
        Down8.Play("FlipDown");
    }
    public void carta9Down()
    {
        Down9.Play("FlipDown");
    }
    public void carta10Down()
    {
        Down10.Play("FlipDown");
    }
    public void carta11Down()
    {
        Down11.Play("FlipDown");
    }
    public void carta12Down()
    {
        Down12.Play("FlipDown");
    }

    public void fuera()
    {
        fr1 = 0;
        fr2 = 0;
        fe1 = 0;
        fe2 = 0;
        fc1 = 0;
        fc2 = 0;
        fp1 = 0;
        fp2 = 0;
        fg1 = 0;
        fg2 = 0;
        fpa1 = 0;
        fpa2 = 0;

        tr1 = 2.0f;
        tr2 = 2.0f;
        tc1 = 2.0f;
        tc2 = 2.0f;
        tp1 = 2.0f;
        tp2 = 2.0f;
        te1 = 2.0f;
        te2 = 2.0f;
        tg1 = 2.0f;
        tg2 = 2.0f;
        tpa1 = 2.0f;
        tpa2 = 2.0f;
    }
}