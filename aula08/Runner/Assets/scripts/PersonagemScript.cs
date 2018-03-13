using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemScript : MonoBehaviour {


	Vector3 novaPosicao;
	Animation ani ;

	public float velocidade;
	public GameObject personagem;


	void OnCollisionEnter(Collision c){
		print (c);
		if (c.gameObject.tag == "item") {
			Destroy (c.gameObject);
		}
	}


	// Use this for initialization
	void Start () {
	
		novaPosicao = transform.position;
		ani = personagem.GetComponent<Animation> ();

		ani.CrossFade ("idle");

	}

 
	// Update is called once per frame
	void Update () {

		//Touch ou click

		if (Input.GetButton ("Fire1")) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);


			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name != "personagem-mover") {


				novaPosicao = hit.point;
				transform.position = Vector3.MoveTowards (transform.position,  new Vector3(novaPosicao.x,0,novaPosicao.z), velocidade * Time.deltaTime);
				ani.CrossFade ("run"); 
				transform.LookAt (hit.point);
			} 
		
		} else {
			ani.CrossFade ("idle");
		}
	


	}
}
