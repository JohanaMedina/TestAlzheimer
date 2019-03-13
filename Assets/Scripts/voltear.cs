using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voltear : MonoBehaviour {

    public Animation Up1, Up2, Up3, Up4, Up5, Up6, Up7, Up8, Down1, Down2, Down3, Down4, Down5, Down6, Down7, Down8;
    //public GameObject aviso;
    public int volteo1, volteo2, empezar, rosa1, rosa2, pera1, pera2, corona1, corona2, estrella1, estrella2, t = 0, count = 0, cr, cp, cc, ce;
    public int sr1 = 0, sr2 = 0, sc1 = 0, sc2 = 0, se1 = 0, se2 = 0, sp1 = 0, sp2 = 0, contr1, contr2, contp1, contp2, conte1, conte2, contc1, contc2;
    public int aux = 0;
    public float tiempo;

    // Use this for initialization
    void Start() {

        volteo1 = 0;
        volteo2 = 0;
        empezar = 0;
        rosa1 = 0;
        rosa2 = 0;
        pera1 = 0;
        pera2 = 0;
        corona1 = 0;
        corona2 = 0;
        estrella1 = 0;
        estrella2 = 0;
        tiempo = 5.0f;
        cp = 0;
        cr = 0;
        ce = 0;
        cc = 0;
        contr1 = 0;
        contr2 = 0;
        contp1 = 0;
        contp2 = 0;
        conte1 = 0;
        conte2 = 0;
        contc1 = 0;
        contc2 = 0;

    }

    // Update is called once per frame
    void Update()
    {
        aux = contr1 + contr2 + contp1 + contp2 + conte1 + conte2 + contc1 + contc2;
        count = ce + cc + cp + cr;

        if (t == 1 && !Down1.isPlaying && !Down2.isPlaying&&!Down5.isPlaying&&!Down4.isPlaying&&!Down8.isPlaying)
        {
            tiempo -= Time.deltaTime;
        }
        if (corona1 == 1 && tiempo <= 0&&sc1==0)
        {
            Up1.Play();
            contc1 = 1;
            tiempo = 5.0f;
            t = 0;
            sc1 = 1;
            if (volteo1 == 1)
            {
                volteo2 = 1;
            }
            volteo1 = 1;
        }
        if (rosa1 == 1 && tiempo <= 0&&sr1==0)
        {
            Up2.Play();
            contr1 = 1;
            tiempo = 5.0f;
            t = 0;
            sr1 = 1;
            if (volteo1 == 1)
            {
                volteo2 = 1;
            }
            volteo1 = 1;
        }
        if (corona2 == 1 && tiempo <= 0 && sc2 == 0)
        {
            Up5.Play();
            contc2 = 0;
            tiempo = 5.0f;
            t = 0;
            sc2 = 1;
            if (volteo1 == 1)
            {
                volteo2 = 1;
            }
            volteo1 = 1;
        }
        if (rosa2 == 1 && tiempo <= 0 && sr2 == 0)
        {
            Up8.Play();
            contr2 = 1;
            tiempo = 5.0f;
            t = 0;
            sr2 = 1;
            if (volteo1 == 1)
            {
                volteo2 = 1;
            }
            volteo1 = 1;
        }
        if (pera1 == 1 && tiempo <= 0 && sp1 == 0)
        {
            Up4.Play();
            contp1 = 1;
            tiempo = 5.0f;
            t = 0;
            sp1 = 1;
            if (volteo1 == 1)
            {
                volteo2 = 1;
            }
            volteo1 = 1;
        }
        if (volteo1 == 1 && volteo2 == 1&&aux==2&&!Up1.isPlaying&&!Up2.isPlaying&&!Up5.isPlaying&&!Up4.isPlaying&&!Up8.isPlaying)
        {
            aux = 0;
            if (rosa1 == 1 && rosa2 == 0)
            {
                carta2Down();
                volteo1 = 0;
                volteo2 = 0;
                rosa1 = 0;
                sr1 = 0;
                contr1 = 0;

            }
            if (rosa1 == 0 && rosa2 == 1)
            {
                carta8Down();
                volteo1 = 0;
                volteo2 = 0;
                rosa2 = 0;
                sr2 = 0;
                contr2 = 0;

            }
            if (pera1 == 1 && pera2 == 0)
            {
                carta4Down();
                volteo1 = 0;
                volteo2 = 0;
                pera1 = 0;
                sp1 = 0;
                contp1 = 0;
            }
          
            if (corona1 == 1 && corona2 == 0)
            {
                carta1Down();
                volteo1 = 0;
                volteo2 = 0;
                corona1 = 0;
                sc1 = 0;
                contc1 = 0;
            }
            if (corona1 == 0 && corona2 == 1)
            {
                carta5Down();
                volteo1 = 0;
                volteo2 = 0;
                corona2 = 0;
                sc2 = 0;
                contc2 = 0;
            }
           
            if (rosa1 == 1 && rosa2 == 1)
            {
                volteo1 = 0;
                volteo2 = 0;
                cr = 1;
                contr1 = 0;
                contr2 = 0;
            }
           
            if (corona1 == 1 && corona2 == 1)
            {
                volteo1 = 0;
                volteo2 = 0;
                cc = 1;
                contc1 = 0;
                contc2 = 0;
            }
            
        }
        
    }
    public void carta1Up()
    {
        tiempo = 5.0f;
        if (sc1 == 0)
        {
            t = 1;
            corona1 = 1;
            
        }
        
    }
    public void carta2Up()
    {
        tiempo = 5.0f;
        if (sr1 == 0) {
            t = 1;
            rosa1 = 1;
               
        }
    }
    public void carta3Up()
    {
        t = 1;
        if (tiempo <= 0)
        {
            Up3.Play();
            //volteo1 = 1;
            //estrella1 = 1;
            //if (volteo1 == 1)
            //{
            //    volteo2 = 1;
            //}
        }
    }
    public void carta4Up()
    {
        tiempo = 5.0f;
        if (sp1 == 0)
        {
            t = 1;
            pera1 = 1;
        }
    }
    public void carta5Up()
    {
        tiempo = 5.0f;
       
        if (sc2 == 0)
        {
            t = 1;
            corona2 = 1;
        }
    }
    public void carta6Up()
    {
        t = 1;
        if (tiempo <= 0)
        {
            Up6.Play();
            //volteo1 = 1;
            //estrella2 = 1;
            //if (volteo1 == 1)
            //{
            //    volteo2 = 1;
            //}
        }
    }
    public void carta7Up()
    {
        t = 1;
        if (tiempo <= 0)
        {
            Up7.Play();
            //volteo1 = 1;
            //pera2 = 1;
            //if (volteo1 == 1)
            //{
            //    volteo2 = 1;
            //}
        }
    }
    public void carta8Up()
    {
        tiempo = 5.0f;
        if (sr2 == 0)
        {
            t = 1;
            rosa2 = 1;
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
    public void fuera() {
        t = 0;
        tiempo = 5.0f;
        //corona1 = 0;
    }
}
