using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlinkScript : MonoBehaviour {

	public float intervalo = 0.5f;

	// Use this for initialization
	IEnumerator Start () {
	
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo);

		StartCoroutine (Start());
	}
	
	 
	void Update(){
	

		if(Input.GetKeyDown(KeyCode.Return)){
			
			SceneManager.LoadScene("games-scene");
		}
		
	}
}
