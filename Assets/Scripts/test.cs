using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


    public ParticleSystem pr1, pr2, pc1, pc2, pe1, pe2, pp1, pp2;
    public float y;
    public GameObject ob1;

	void Start () {
        y = 0;
        pr1.Stop();
        pr2.Stop();
        pc1.Stop();
        pc2.Stop();
        pe1.Stop();
        pe2.Stop();
        pp1.Stop();
        pp2.Stop();

    }

    // Update is called once per frame
    void Update() {
        ob1.transform.Rotate(0, 0, 0);
        if (Input.GetKey("r"))
        {
            pr1.Play();
            pr2.Play();
        }
        if (Input.GetKey("q"))
        {
            pr1.Stop();
            pr2.Stop();
        }

        if (Input.GetKey("c"))
        {
            pc1.Play();
            pc2.Play();
        }
        if (Input.GetKey("w"))
        {
            pc1.Stop();
            pc2.Stop();
        }
        if (Input.GetKey("e"))
        {
            pe1.Play();
            pe2.Play();
        }
        if (Input.GetKey("a"))
        {
            pe1.Stop();
            pe2.Stop();
        }
        if (Input.GetKey("p"))
        {
            pp1.Play();
            pp2.Play();
        }
        if (Input.GetKey("s"))
        {
            pp1.Stop();
            pp2.Stop();
        }
    }
}
