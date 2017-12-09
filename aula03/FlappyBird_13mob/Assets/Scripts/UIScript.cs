using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour {

	public Text txtPontos;
	public Text total;
	public GameObject modedaprata;
	public GameObject modedaouro;

	
	// Update is called once per frame
	void Update () { 

		if (PrincipalScript.pontos >= 5) {
			modedaprata.SetActive (false);
			modedaouro.SetActive (true);
		}

		txtPontos.text = PrincipalScript.pontos.ToString ();
		total.text = PrincipalScript.pontos.ToString ();

	}
}
