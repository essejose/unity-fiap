using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {


	public GameObject projetil;
	public GameObject sensorRotacao;

	// Use this for initialization
	void Start () {
	//	StartCoroutine (fire ());
	}
	
	// Update is called once per frame
	void Update () {
		 
	

		if (Input.GetButtonUp("Fire1")) {

			Instantiate (projetil, transform.position, transform.rotation);
		}

		if (Input.GetAxisRaw ("Horizontal") > 0.0f) {

			sensorRotacao.transform.eulerAngles =new  Vector3 (0.0f, 0.0f, 0.0f);
		} else if (Input.GetAxisRaw ("Horizontal") < 0.0f) {

			sensorRotacao.transform.eulerAngles = new Vector3 (0.0f, 180.0f, 0.0f);

		}

	}

	IEnumerator fire(){



		if (Input.GetButtonUp("Fire1")) {

			Instantiate (projetil, transform.position, transform.rotation);
		}
		yield return new WaitForSeconds (0.1f);
		StartCoroutine (fire ());

	}

}
