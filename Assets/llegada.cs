using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llegada : MonoBehaviour {
    public int f = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        f = 1;
    }
}
