using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfiniteMove : MonoBehaviour {

	private float moveSpeed = 0.07f; //sets a var for move speed
	private float lastMoveSpeed = 0f;
	private float gametimer = 1;

	// Use this for initialization

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		gametimer += 1;
		if (gametimer >= 60*30){
			if (moveSpeed == 0f) {
				lastMoveSpeed = 0.1f;
			} else {
				moveSpeed = 0.1f;
			}
		}

		if (gametimer >= 60*75){
			if (moveSpeed == 0f) {
				lastMoveSpeed = 0.12f;
			} else {
				moveSpeed = 0.12f;
			}
		}

		if (Input.GetKeyDown(KeyCode.Z)){
			lastMoveSpeed = moveSpeed;
			moveSpeed = 0f;
			//transform.Translate (0, 0, 0);
		}

		if (Input.GetKeyUp(KeyCode.Z)){
			moveSpeed = lastMoveSpeed;
			//transform.Translate (0, 0, 0);
		}

		transform.Translate (moveSpeed * Time.deltaTime * 60, 0, 0); //sets text to move

	}
}
