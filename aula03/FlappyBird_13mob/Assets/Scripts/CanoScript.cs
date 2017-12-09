using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour {


	public float velocidade ;
	public float alturaInicial, alturaFinal;
	public float limeteX;

 
	void Start(){
		velocidade = 3f;
		alturaInicial = -1.0f;
		alturaFinal = 3.0f;
		limeteX = -6f;

	}

	// Update is called once per frame
	void Update () {

		if (FlappyBirdScript.inGame) {
			transform.Translate (Vector2.left * velocidade * Time.deltaTime);

			if (transform.position.x <= limeteX) {
			
				transform.position = new Vector2 (limeteX * -1,
					Random.Range (alturaInicial, alturaFinal));
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider){
	

		PrincipalScript.pontos++;
	 
	}


}
