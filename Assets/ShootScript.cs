using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	public Transform bulletPrefab;
	private const int maxBullets = 3;
	private GameObject playerObject;

	// Use this for initialization
	void Start () {
		playerObject = GameObject.Find("PlayerChar");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X)) {
			var numBullets = GameObject.FindGameObjectsWithTag("bullet").Length;
			if (numBullets < maxBullets) {
				Instantiate (bulletPrefab, playerObject.transform.position, playerObject.transform.rotation);
			}
		}
	}
}
