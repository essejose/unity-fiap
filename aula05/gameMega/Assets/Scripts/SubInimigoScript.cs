using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigoScript : MonoBehaviour {


	public GameObject alvo;
	public float velocidade;

	// Use this for initialization
	void Start () {
			
		alvo = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		
		if (alvo != null) {
			
		float flipCheck = transform.position.x - alvo.transform.position.x; 
		GetComponent<SpriteRenderer> ().flipX = flipCheck < 0; 
			transform.position = Vector2.Lerp (
				transform.position, alvo.transform.position,
				velocidade * Time.deltaTime);
		}
	
	}
}
