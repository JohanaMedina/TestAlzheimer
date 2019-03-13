using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandos : MonoBehaviour {
   
    int nu = 0;
    public TextMesh numero;

    void Start () {
        
    }
	
	
	void Update () {
        numero.text = nu.ToString();
        PlayerPrefs.SetString("nu", nu.ToString());
        
	}
    public void OnClick1()
    {
        Application.LoadLevel("preview");
    }
    public void OnClick2()
    {
        Application.LoadLevel("cartas2");
    }
    public void OnClick3()
    {
        Application.LoadLevel("cartas3");
    }
    public void OnClick4()
    {
        Application.LoadLevel("resultados");
    }

    public void subir()
    {
        nu++;
    
    }
    public void bajar()
    {

        nu--;
    }
}
