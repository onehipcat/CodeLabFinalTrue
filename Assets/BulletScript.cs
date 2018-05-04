using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	private float moveSpeed = 0.14f; //sets a var for move speed
	private float gametimer = 1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		gametimer += 1;
		if (gametimer >= 1.3 * 60){
			Destroy (this.gameObject);
		}
		transform.Translate (moveSpeed * Time.deltaTime * 60, 0, 0);
	}
}
