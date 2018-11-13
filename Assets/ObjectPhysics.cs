using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour {


    Rigidbody body;

    public float force;
    public Vector3 forceVec = new Vector3(0.0f, 1.0f, 0.0f);

	// Use this for initialization
	void Start () {
        this.body = GetComponent<Rigidbody>();
        //force = 9.81f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        body.AddForce(force * forceVec.normalized);
    }
}
