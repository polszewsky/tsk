using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {

    public GameObject speaker;
    public GameObject ball;
    public float distance_;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    private void FixedUpdate()
    {

        distance_ = Vector3.Distance(speaker.transform.position, ball.transform.position);
    }
}
