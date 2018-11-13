using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcousticForces : MonoBehaviour
{
    public GameObject ball;
    public GameObject source;

    public Rigidbody rb;
    public Wave wave;
    public Distance distance;

    private double dlugosc;
    private double odleglosc;
    public Vector3 force;

    // Use this for initialization
    void Start()
    {
        odleglosc = source.GetComponent<Distance>().GetDistance();
        dlugosc = source.GetComponent<Wave>().GetDlugosc();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        odleglosc = source.GetComponent<Distance>().GetDistance();
        dlugosc = source.GetComponent<Wave>().GetDlugosc();
        rb = ball.GetComponent<Rigidbody>();

        Debug.Log("modulo" + odleglosc % dlugosc);

        if (odleglosc % dlugosc < 0.2)
        {
            
            rb.AddForce(force);
        }
        else
        {
            rb.AddForce(1.0f * new Vector3(0,1,0).normalized);
        }
   

       // rb = ball.GetComponent<Rigidbody>();

    }
}
