using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller2 : MonoBehaviour
{
    public float speed = 10.0f, t = 0.0f;
    public GameObject complete;
    private Rigidbody rb;
    public string tc;
    private double[] myProxyPosition = new double[3];

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        complete.SetActive(false);
        tc = "tlaberinto2" + PlayerPrefs.GetString("nu");
    }

    void Update()
    {
        t += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("llegada"))
        {
            complete.SetActive(true);
            PlayerPrefs.SetString(tc, t.ToString("f0"));
            Application.LoadLevel("lugar3_1");
        }
    }
}
