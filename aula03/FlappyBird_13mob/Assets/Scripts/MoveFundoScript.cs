﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFundoScript : MonoBehaviour {
 	
	public  float velocidade;
	public float posicaoInicial, posicaoFinal;

	// Update is called once per frame
	void Update () {

		if (FlappyBirdScript.inGame) {
			if (transform.position.x <= posicaoFinal) {
				transform.position = new Vector2 (posicaoInicial, transform.position.y);

			}

			transform.Translate (Vector2.left * velocidade * Time.deltaTime);
		}

	}
}
