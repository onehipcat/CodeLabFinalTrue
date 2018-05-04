﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) { //calls collider function
		if (other.gameObject.GetComponent<Player> ()) {
			SceneManager.LoadScene ("winscene");
		}
	}
}
