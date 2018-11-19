using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcousticForces : MonoBehaviour
{
    public float i;
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
        /*
        if (odleglosc % dlugosc < 0.3)
        {
            
            rb.AddForce(force);
        }
        else
        {
            rb.AddForce(1.0f * new Vector3(0,1,0).normalized);
        }*/

        //sin(2 * Math.PI * wave.czestotliwosc * (odleglosc / wave.predkosc) + wave.przesuniecie);
        float f = (float)(Math.Sin(2 * Math.PI * wave.czestotliwosc * (odleglosc / wave.predkosc) + Math.PI / i) + 1.0)
            * 10.0f;
        Debug.Log(f);
        rb.AddForce( f * force.normalized);

       // rb = ball.GetComponent<Rigidbody>();

    }
}
