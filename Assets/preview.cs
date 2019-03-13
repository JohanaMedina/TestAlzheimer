using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preview : MonoBehaviour {

    public float timer; 
	void Start () {
        timer = 15.0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0)
            Application.LoadLevel("cartas1");
	}
}
