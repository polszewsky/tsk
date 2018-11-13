using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parameters : MonoBehaviour {

    public InputField f;
    public InputField m;

    public GameObject glosnik;
    public GameObject ball;

    public Wave wave;

    public void Accept_Click()
    {

        wave = glosnik.GetComponent<Wave>();
        wave.czestotliwosc = (Convert.ToSingle(f.text) * 1000 );
        // .czes = Convert.ToSingle(f.text);

        Rigidbody rb = ball.GetComponent<Rigidbody>();

        rb.mass = ( Convert.ToSingle(m.text) * 1.0f );
    }
}
