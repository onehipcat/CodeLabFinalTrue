using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

	public Vector3 jump;
	public float jumpForce = 2.0f;

	public bool isGrounded = false;
	Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
		jump = new Vector3(0.0f, 2.0f, 0.0f);
	}

	void OnCollisionStay2D(Collision2D collision)
	{
		if (rb.velocity.y == 0) {
			isGrounded = true;
		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true ){
			rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
			isGrounded = false;
		}
	}
}