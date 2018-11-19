using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballDrag : MonoBehaviour {

    public Text buttonText;
    public GameObject ball;


    public void Slider_ChangedP(float newValue)
    {
        Vector3 pos = ball.transform.position;
        pos.y = newValue;
        ball.transform.position = pos;
    }

	// Use this for initialization
	public void Button_Click () {
        Debug.Log("hello world!");
	}
	
	// Update is called once per frame
	public void Button_String (string msg) {
        buttonText.text = msg;
	}
}
