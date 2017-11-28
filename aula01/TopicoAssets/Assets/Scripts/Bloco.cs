using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D c){
	
		print ("colidiu");
			
		print (c.gameObject.tag);
		if (c.gameObject.tag == "Player") {
		  	
			Destroy ( gameObject);
			transform.Translate(0.0f, 0.0f,0.0f);
		}

	}


	void OnCollisionStay2D( Collision2D c){


		print ("estou colidindo");
	}

	void OnCollisionExit2D(Collision2D c){

		print ("parei de colidi");
	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back * 50 * Time.deltaTime);
	}
}
