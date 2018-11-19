using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public double czestotliwosc; //Hz || 2Hz = 1/2s etc...
    public double dlugosc;       //
    public double predkosc = 34000; //cm/s

    public float przesuniecie;

    void Start()
    {
        dlugosc = ((1 / czestotliwosc) * predkosc) * 100;
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void FixedUpdate()
    {
        dlugosc = ((1 / czestotliwosc) * predkosc);
        Debug.Log(dlugosc.ToString() + " cm");
    }

    internal double GetDlugosc()
    {
        return Math.Round(dlugosc,2);
    }

}
