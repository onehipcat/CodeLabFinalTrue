using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyWhenShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "bullet") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);

		} else if (other.tag == "Player") {
			Player.health -= 1;
		}
	}
}
