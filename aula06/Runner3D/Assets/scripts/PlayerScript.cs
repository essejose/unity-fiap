using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	float direcao_x;
	float posicaoInicial_x;
	float posicaoFinal_x;
	public Transform[] posicoes;
	public float velociadade;
	int posicaoAtual = 1;

	// Update is called once per frame
	void Update () {

		//Fire1 - clique do mouse, touch ou ctrl esquerdo;
		if (Input.GetButtonDown ("Fire1")) {
			
			posicaoInicial_x = Input.mousePosition.x;

		} else if (Input.GetButtonUp ("Fire1")) {

			posicaoFinal_x = Input.mousePosition.x;
			direcao_x = posicaoFinal_x - posicaoInicial_x;
			 
			if (direcao_x > 0 && posicaoAtual < 2) {

				print ("Direito");
				posicaoAtual++;

			}else if (direcao_x < 0 && posicaoAtual > 0) {
				print ("esquerdo");
				posicaoAtual --;

			}

		}
	

	 
		transform.position = Vector3.Lerp (transform.position, posicoes[posicaoAtual].position,	velociadade * Time.deltaTime); 
	
	}

}
