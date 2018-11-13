using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public double czestotliwosc; //Hz || 2Hz = 1/2s etc...
    public double dlugosc;       //
    public double predkosc = 340.12; //m/s


	
	// Update is called once per frame
	void Update () {

    }

    private void FixedUpdate()
    {
        Debug.Log(czestotliwosc);

        dlugosc = ((1 / czestotliwosc) * predkosc) * 100;
        Debug.Log(dlugosc.ToString() + " cm");
    }
}
