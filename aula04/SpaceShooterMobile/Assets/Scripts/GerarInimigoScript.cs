using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigoScript : MonoBehaviour {

	public GameObject inimigo;
	public float limiteEsquerdo, limiteDireito;
	public float tempoInicial, tempoFinal;
	
	IEnumerator Start(){

		yield return new WaitForSeconds(Random.Range(tempoInicial,tempoFinal));

		Vector2 posicao = new Vector2 (
			(Random.Range (limiteEsquerdo, limiteDireito)),
			                  transform.position.y);
		

		Instantiate (inimigo, posicao, transform.rotation);

		StartCoroutine (Start ());

	}
}
