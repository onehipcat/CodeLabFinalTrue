using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {

	Text myText;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> (); //sets a variable for getting the UI text component
	}

	// Update is called once per frame
	void Update () {
		myText.text = "HEALTH: " + Player.health; //displays health on the UI text
	}
}