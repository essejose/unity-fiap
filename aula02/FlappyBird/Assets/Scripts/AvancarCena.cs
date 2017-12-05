using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvancarCena : MonoBehaviour {

	public string cena;

	// Update is called once per frame
	void Update () {

		//FIRE1 -> Touch, CTRL+LEFT, CLICKLEFT
		if (Input.GetButtonDown ("Fire1")) { 
 
			SceneManager.LoadScene (cena); 
		
		}

	}
}
