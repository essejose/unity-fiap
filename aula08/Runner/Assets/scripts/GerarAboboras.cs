using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarAboboras : MonoBehaviour {

	public float limiteEsquerdo, limiteDireito, limiteFrontal, limiteTraseiro;
	public float frequencia;
	public GameObject aboboraPrefab;


	// Use this for initialization
	IEnumerator Start () {

		yield return new WaitForSeconds (Random.Range (0.5f, frequencia));

		Vector3 posicao;
		posicao.x = Random.Range (limiteEsquerdo, limiteDireito);
		posicao.y = 20.0f;
		posicao.z = Random.Range (limiteFrontal, limiteTraseiro);
		Instantiate (aboboraPrefab, posicao, transform.rotation);

		StartCoroutine (Start ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
