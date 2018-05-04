﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour {

	private float moveSpeed = 0.05f; //sets a var for move speed
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, moveSpeed * Time.deltaTime * 60, 0); //sets text to move
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "ground") {
			moveSpeed *= -1;
		}else if (other.tag == "Player") {
			Player.health -= 1;
		}
	}
}
