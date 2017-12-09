using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {

	public static bool inGame;

	GameObject lb;

	public  float inpulso ;

	Rigidbody2D rb;



	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

		lb = GameObject.Find ("label");
		 
		rb.gravityScale = 0.0f;
		inpulso = 5.0f;
 		
	}
	
	// Update is called once per frame
	void Update () {

		if (!inGame && Input.GetButtonDown("Fire1")) {
			
			rb.gravityScale = 1.0f;
			inGame = true;
		 

		}else if (inGame && Input.GetButtonDown("Fire1")){

			rb.velocity = new Vector2(0.0f, inpulso);
			rb.AddForce (new Vector2(1f, 0.0f));

		}
		 


	}

	void OnCollisionEnter2D(Collision2D c) {

		inGame = false;
		SceneManager.LoadScene ("start");

	}

}
