using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public static int health = 4;



	// Use this for initialization
	void Start () {
		health = 4;
	}

	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			SceneManager.LoadScene ("WelcomeScene");
		}

	}
}