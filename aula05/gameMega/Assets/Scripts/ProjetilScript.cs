using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;
	public float tempoDeVida;
	public GameObject explosao;
	 

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, tempoDeVida);

		 
	}
	
	// Update is called once per frame
	void Update () {
		
		 
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D c){

		if (c.gameObject.tag == "Inimigo") {

			Instantiate (explosao, transform.position,transform.rotation);



			Destroy (c.gameObject);
			Destroy (gameObject);
			//PontuacaoScript.score++;

		}

	}

}
