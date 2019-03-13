using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultados : MonoBehaviour {

    public TextMesh Ecartas, Acartas, Tcartas, nu, Ecaras, Acaras, Tcaras, Ehistoria, Ahistoria, Thistoria, Efiguras, Afiguras, Tfiguras, Eclima, Aclima, Tclima;
    public TextMesh Esecuencia, Asecuencia, Tsecuencia, Eafirmacion, Aafirmacion, Tafirmacion, Evoz, Avoz, Tvoz, Tlaberinto, Elugar, Alugar, Tlugar;
    public TextMesh Epasos, Apasos, Tpasos, Eplan, Aplan, Tplan;
    public int num=0;
    public string ac, ec, tc, aca, eca, tca, ase, ese, tse, ahi, ehi, thi, eaf, aaf, taf, ev, av, tv, afig, efig, tfig, tlab, elu, alu, tlu, ecl, acl, tcl;
    public string apa, epa, tpa, epl, apl, tpl;

    public TextMesh Ecartas2, Acartas2, Tcartas2, Ecaras2, Acaras2, Tcaras2, Ehistoria2, Ahistoria2, Thistoria2, Efiguras2, Afiguras2, Tfiguras2, Eclima2, Aclima2, Tclima2;
    public TextMesh Esecuencia2, Asecuencia2, Tsecuencia2, Eafirmacion2, Aafirmacion2, Tafirmacion2, Evoz2, Avoz2, Tvoz2, Tlaberinto2, Elugar2, Alugar2, Tlugar2;
    public TextMesh Epasos2, Apasos2, Tpasos2, Eplan2, Aplan2, Tplan2;
    public string ac2, ec2, tc2, aca2, eca2, tca2, ase2, ese2, tse2, ahi2, ehi2, thi2, eaf2, aaf2, taf2, ev2, av2, tv2, afig2, efig2, tfig2, tlab2, elu2, alu2, tlu2, ecl2, acl2, tcl2;
    public string apa2, epa2, tpa2, epl2, apl2, tpl2;

    public TextMesh Ecartas3, Acartas3, Tcartas3, Ecaras3, Acaras3, Tcaras3, Ehistoria3, Ahistoria3, Thistoria3, Efiguras3, Afiguras3, Tfiguras3, Eclima3, Aclima3, Tclima3;
    public TextMesh Esecuencia3, Asecuencia3, Tsecuencia3, Eafirmacion3, Aafirmacion3, Tafirmacion3, Evoz3, Avoz3, Tvoz3, Tlaberinto3, Elugar3, Alugar3, Tlugar3;
    public TextMesh Epasos3, Apasos3, Tpasos3, Eplan3, Aplan3, Tplan3;
    public string ac3, ec3, tc3, aca3, eca3, tca3, ase3, ese3, tse3, ahi3, ehi3, thi3, eaf3, aaf3, taf3, ev3, av3, tv3, afig3, efig3, tfig3, tlab3, elu3, alu3, tlu3, ecl3, acl3, tcl3;
    public string apa3, epa3, tpa3, epl3, apl3, tpl3;

    public int f = 1;
    public GameObject uno, dos, tres;

    void Start () {
        uno.SetActive(true);
        dos.SetActive(false);
        tres.SetActive(false);
    }
	
	
	void Update ()
    {
        nu.text = num.ToString();

        //juegos nivel I
        ac = "acartas" + num.ToString();
        ec = "ecartas" + num.ToString();
        tc = "tcartas" + num.ToString();
        aca = "acaras1" + num.ToString();
        eca = "ecaras1" + num.ToString();
        tca = "tcaras1" + num.ToString();
        ehi = "ehistoria1" + num.ToString();
        ahi = "ahistoria1" + num.ToString();
        thi = "thistoria1" + num.ToString();
        ese = "esecuencia1" + num.ToString();
        ase = "asecuencia1" + num.ToString();
        tse = "tsecuencia1" + num.ToString();
        eaf = "eafirmacion1" + num.ToString();
        aaf = "aafirmacion1" + num.ToString();
        taf = "tafirmacion1" + num.ToString();
        ev = "evoz1" + num.ToString();
        av = "avoz1" + num.ToString();
        tv = "tvoz1" + num.ToString();
        efig = "efiguras1" + num.ToString();
        afig = "afiguras1" + num.ToString();
        tfig = "tfiguras1" + num.ToString();
        tlab = "tlaberinto1" + num.ToString();
        elu = "elugar1" + num.ToString();
        alu = "alugar1" + num.ToString();
        tlu = "tlugar1" + num.ToString();
        ecl = "eclima1" + num.ToString();
        acl = "aclima1" + num.ToString();
        tcl = "tclima1" + num.ToString();
        epa = "epasos1" + num.ToString();
        apa = "apasos1" + num.ToString();
        tpa = "tpasos1" + num.ToString();
        epl = "eplan1" + num.ToString();
        apl = "aplan1" + num.ToString();
        tpl = "tplan1" + num.ToString();

        Ecartas.text = PlayerPrefs.GetString(ec);
        Acartas.text = PlayerPrefs.GetString(ac);
        Tcartas.text = PlayerPrefs.GetString(tc)+" s";
        Ecaras.text = PlayerPrefs.GetString(eca);
        Acaras.text = PlayerPrefs.GetString(aca);
        Tcaras.text = PlayerPrefs.GetString(tca) + " s";
        Ehistoria.text = PlayerPrefs.GetString(ehi);
        Ahistoria.text = PlayerPrefs.GetString(ahi);
        Thistoria.text = PlayerPrefs.GetString(thi) + " s";
        Esecuencia.text = PlayerPrefs.GetString(ese);
        Asecuencia.text = PlayerPrefs.GetString(ase);
        Tsecuencia.text = PlayerPrefs.GetString(tse) + " s";
        Eafirmacion.text = PlayerPrefs.GetString(eaf);
        Aafirmacion.text = PlayerPrefs.GetString(aaf);
        Tafirmacion.text = PlayerPrefs.GetString(taf) + " s";
        Evoz.text = PlayerPrefs.GetString(ev);
        Avoz.text = PlayerPrefs.GetString(av);
        Tvoz.text = PlayerPrefs.GetString(tv) + " s";
        Efiguras.text = PlayerPrefs.GetString(efig);
        Afiguras.text = PlayerPrefs.GetString(afig);
        Tfiguras.text = PlayerPrefs.GetString(tfig) + " s";
        Tlaberinto.text = PlayerPrefs.GetString(tlab) + " s";
        Elugar.text = PlayerPrefs.GetString(elu);
        Alugar.text = PlayerPrefs.GetString(alu);
        Tlugar.text = PlayerPrefs.GetString(tlu) + " s";
        Eclima.text = PlayerPrefs.GetString(ecl);
        Aclima.text = PlayerPrefs.GetString(acl);
        Tclima.text = PlayerPrefs.GetString(tcl) + " s";
        Epasos.text = PlayerPrefs.GetString(epa);
        Apasos.text = PlayerPrefs.GetString(apa);
        Tpasos.text = PlayerPrefs.GetString(tpa) + " s";
        Eplan.text = PlayerPrefs.GetString(epl);
        Aplan.text = PlayerPrefs.GetString(apl);
        Tplan.text = PlayerPrefs.GetString(tpl) + " s";

        //juegos nivel II
        ac2 = "acartas2" + num.ToString();
        ec2 = "ecartas2" + num.ToString();
        tc2 = "tcartas2" + num.ToString();
        aca2 = "acaras2" + num.ToString();
        eca2 = "ecaras2" + num.ToString();
        tca2 = "tcaras2" + num.ToString();
        ehi2 = "ehistoria2" + num.ToString();
        ahi2 = "ahistoria2" + num.ToString();
        thi2 = "thistoria2" + num.ToString();
        ese2 = "esecuencia2" + num.ToString();
        ase2 = "asecuencia2" + num.ToString();
        tse2 = "tsecuencia2" + num.ToString();
        eaf2 = "eantonimos1" + num.ToString();
        aaf2 = "aantonimos1" + num.ToString();
        taf2 = "tantonimos1" + num.ToString();
        ev2 = "evoz2" + num.ToString();
        av2 = "avoz2" + num.ToString();
        tv2 = "tvoz2" + num.ToString();
        efig2 = "efiguras2" + num.ToString();
        afig2 = "afiguras2" + num.ToString();
        tfig2 = "tfiguras2" + num.ToString();
        tlab2 = "tlaberinto2" + num.ToString();
        elu2 = "elugar2" + num.ToString();
        alu2 = "alugar2" + num.ToString();
        tlu2 = "tlugar2" + num.ToString();
        ecl2 = "eclima2" + num.ToString();
        acl2 = "aclima2" + num.ToString();
        tcl2 = "tclima2" + num.ToString();
        epa2 = "epasos2" + num.ToString();
        apa2 = "apasos2" + num.ToString();
        tpa2 = "tpasos2" + num.ToString();
        epl2 = "eplan2" + num.ToString();
        apl2 = "aplan2" + num.ToString();
        tpl2 = "tplan2" + num.ToString();

        Ecartas2.text = PlayerPrefs.GetString(ec2);
        Acartas2.text = PlayerPrefs.GetString(ac2);
        Tcartas2.text = PlayerPrefs.GetString(tc2) + " s";
        Ecaras2.text = PlayerPrefs.GetString(eca2);
        Acaras2.text = PlayerPrefs.GetString(aca2);
        Tcaras2.text = PlayerPrefs.GetString(tca2) + " s";
        Ehistoria2.text = PlayerPrefs.GetString(ehi2);
        Ahistoria2.text = PlayerPrefs.GetString(ahi2);
        Thistoria2.text = PlayerPrefs.GetString(thi2) + " s";
        Esecuencia2.text = PlayerPrefs.GetString(ese2);
        Asecuencia2.text = PlayerPrefs.GetString(ase2);
        Tsecuencia2.text = PlayerPrefs.GetString(tse2) + " s";
        Eafirmacion2.text = PlayerPrefs.GetString(eaf2);
        Aafirmacion2.text = PlayerPrefs.GetString(aaf2);
        Tafirmacion2.text = PlayerPrefs.GetString(taf2) + " s";
        Evoz2.text = PlayerPrefs.GetString(ev2);
        Avoz2.text = PlayerPrefs.GetString(av2);
        Tvoz2.text = PlayerPrefs.GetString(tv2) + " s";
        Efiguras2.text = PlayerPrefs.GetString(efig2);
        Afiguras2.text = PlayerPrefs.GetString(afig2);
        Tfiguras2.text = PlayerPrefs.GetString(tfig2) + " s";
        Tlaberinto2.text = PlayerPrefs.GetString(tlab2) + " s";
        Elugar2.text = PlayerPrefs.GetString(elu2);
        Alugar2.text = PlayerPrefs.GetString(alu2);
        Tlugar2.text = PlayerPrefs.GetString(tlu2) + " s";
        Eclima2.text = PlayerPrefs.GetString(ecl2);
        Aclima2.text = PlayerPrefs.GetString(acl2);
        Tclima2.text = PlayerPrefs.GetString(tcl2) + " s";
        Epasos2.text = PlayerPrefs.GetString(epa2);
        Apasos2.text = PlayerPrefs.GetString(apa2);
        Tpasos2.text = PlayerPrefs.GetString(tpa2) + " s";
        Eplan2.text = PlayerPrefs.GetString(epl2);
        Aplan2.text = PlayerPrefs.GetString(apl2);
        Tplan2.text = PlayerPrefs.GetString(tpl2) + " s";
        
        //juegos nivel III
        ac3 = "acartas3" + num.ToString();
        ec3 = "ecartas3" + num.ToString();
        tc3 = "tcartas3" + num.ToString();
        aca3 = "acaras3" + num.ToString();
        eca3 = "ecaras3" + num.ToString();
        tca3 = "tcaras3" + num.ToString();
        ehi3 = "ehistoria3" + num.ToString();
        ahi3 = "ahistoria3" + num.ToString();
        thi3 = "thistoria3" + num.ToString();
        ese3 = "esecuencia3" + num.ToString();
        ase3 = "asecuencia3" + num.ToString();
        tse3 = "tsecuencia3" + num.ToString();
        eaf3 = "eobjlugar1" + num.ToString();
        aaf3 = "aobjlugar1" + num.ToString();
        taf3 = "tobjlugar1" + num.ToString();
        ev3 = "evoz3" + num.ToString();
        av3 = "avoz3" + num.ToString();
        tv3 = "tvoz3" + num.ToString();
        efig3 = "efiguras3" + num.ToString();
        afig3 = "afiguras3" + num.ToString();
        tfig3 = "tfiguras3" + num.ToString();
        tlab3 = "tlaberinto3" + num.ToString();
        elu3 = "elugar3" + num.ToString();
        alu3 = "alugar3" + num.ToString();
        tlu3 = "tlugar3" + num.ToString();
        ecl3 = "eclima3" + num.ToString();
        acl3 = "aclima3" + num.ToString();
        tcl3 = "tclima3" + num.ToString();
        epa3 = "epasos3" + num.ToString();
        apa3 = "apasos3" + num.ToString();
        tpa3 = "tpasos3" + num.ToString();
        epl3 = "eplan3" + num.ToString();
        apl3 = "aplan3" + num.ToString();
        tpl3 = "tplan3" + num.ToString();

        Ecartas3.text = PlayerPrefs.GetString(ec3);
        Acartas3.text = PlayerPrefs.GetString(ac3);
        Tcartas3.text = PlayerPrefs.GetString(tc3) + " s";
        Ecaras3.text = PlayerPrefs.GetString(eca3);
        Acaras3.text = PlayerPrefs.GetString(aca3);
        Tcaras3.text = PlayerPrefs.GetString(tca3) + " s";
        Ehistoria3.text = PlayerPrefs.GetString(ehi3);
        Ahistoria3.text = PlayerPrefs.GetString(ahi3);
        Thistoria3.text = PlayerPrefs.GetString(thi3) + " s";
        Esecuencia3.text = PlayerPrefs.GetString(ese3);
        Asecuencia3.text = PlayerPrefs.GetString(ase3);
        Tsecuencia3.text = PlayerPrefs.GetString(tse3) + " s";
        Eafirmacion3.text = PlayerPrefs.GetString(eaf3);
        Aafirmacion3.text = PlayerPrefs.GetString(aaf3);
        Tafirmacion3.text = PlayerPrefs.GetString(taf3) + " s";
        Evoz3.text = PlayerPrefs.GetString(ev3);
        Avoz3.text = PlayerPrefs.GetString(av3);
        Tvoz3.text = PlayerPrefs.GetString(tv3) + " s";
        Efiguras3.text = PlayerPrefs.GetString(efig3);
        Afiguras3.text = PlayerPrefs.GetString(afig3);
        Tfiguras3.text = PlayerPrefs.GetString(tfig3) + " s";
        Tlaberinto3.text = PlayerPrefs.GetString(tlab3) + " s";
        Elugar3.text = PlayerPrefs.GetString(elu3);
        Alugar3.text = PlayerPrefs.GetString(alu3);
        Tlugar3.text = PlayerPrefs.GetString(tlu3) + " s";
        Eclima3.text = PlayerPrefs.GetString(ecl3);
        Aclima3.text = PlayerPrefs.GetString(acl3);
        Tclima3.text = PlayerPrefs.GetString(tcl3) + " s";
        Epasos3.text = PlayerPrefs.GetString(epa3);
        Apasos3.text = PlayerPrefs.GetString(apa3);
        Tpasos3.text = PlayerPrefs.GetString(tpa3) + " s";
        Eplan3.text = PlayerPrefs.GetString(epl3);
        Aplan3.text = PlayerPrefs.GetString(apl3);
        Tplan3.text = PlayerPrefs.GetString(tpl3) + " s";

        if (f > 3)
            f = 3;
        if (f < 1)
            f = 1;
        if (f == 1)
        {
            uno.SetActive(true);
            dos.SetActive(false);
            tres.SetActive(false);
        }
        if (f == 2)
        {
            uno.SetActive(false);
            dos.SetActive(true);
            tres.SetActive(false);
        }
        if (f == 3)
        {
            uno.SetActive(false);
            dos.SetActive(false);
            tres.SetActive(true);
        }
    }
    public void subir()
    {
        num++;
    }
    public void bajar()
    {
        num--;
    }
    public void next()
    {
        f++;
    }
    public void before()
    {
        f--;
    }
    public void menu()
    {
        Application.LoadLevel("menu");
    }
}
