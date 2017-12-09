using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {

	public static bool inGame;

	bool endGame;

	public GameObject lb;
	public GameObject panel;

	public  float inpulso ;

	Rigidbody2D rb;



	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

		 
		lb.SetActive (true);

		rb.gravityScale = 0.0f;
		inpulso = 5.0f;

		endGame = false;
 		
	}
	
	// Update is called once per frame
	void Update () {

		if (inGame) {
			lb.SetActive (false);
		}

		if (!inGame && Input.GetButtonDown("Fire1") && !endGame) {
			
			rb.gravityScale = 1.0f;
			inGame = true;
		 

		}else if (inGame && Input.GetButtonDown("Fire1")){
			
			rb.velocity = new Vector2(0.0f, inpulso);
			rb.AddForce (new Vector2(2f, 0.0f));


		}



		if (Input.GetButtonDown("Fire1") && endGame){

			SceneManager.LoadScene ("start");

		}




	}

	void OnCollisionEnter2D(Collision2D c) {

		inGame = false;
		endGame = true;
		panel.SetActive (true);

	}

}
