using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	public int cont;
	public int vel;

	public int velocidade = 20;

	private SpriteRenderer mySpriteRender;

	private Rigidbody2D myBody;

	void Awake()
	{
		myBody = this.GetComponent<Rigidbody2D>(); 
		mySpriteRender = this.GetComponent<SpriteRenderer> ();


	}

	// Use this for initialization
	void Start () {

		//transform.position = new Vector2 (-5.0f, 0.0f);
		//transform.Translate(0.0f,0.0f,0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(5.0f * Time.deltaTime,0.0f,0.0f);
		//transform.Rotate(Vector3.back * velocidade * Time.deltaTime); 
			float move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
			float move_y = Input.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;

		transform.Translate(move_x, move_y,0.0f);
		    
		mySpriteRender.flipX = !(move_x >= 0);
		 
		  
		if (Input.GetButtonDown ("Jump")){

			myBody.AddForce(new Vector2(vel * Random.Range(10,10),200 ));

		}
			 

	}

	void OnMouseDown()
	{

		myBody.AddForce(new Vector2(vel * Random.Range(10,10),200 ));
		cont++;
		vel = vel + 5;
	}
}
