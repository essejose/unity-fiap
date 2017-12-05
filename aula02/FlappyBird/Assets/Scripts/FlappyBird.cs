using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour {

	public float impulso = 5.0f;
	Rigidbody2D rb;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		//
		if (Input.GetButtonDown ("Jump")) {
			//rb.AddForce (Vector2.up * 500.0f);
			rb.velocity = new Vector2 (0.0f, impulso);

		}


	}
}
