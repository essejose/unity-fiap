using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemScript : MonoBehaviour {


	Vector3 novaPosicao;
	Animation ani ;

	public float velocidade;
	public GameObject personagem;
    Rigidbody playerRigidbody;

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
        playerRigidbody = GetComponent<Rigidbody>();
    }

 
	// Update is called once per frame
	void Update () {

		//Touch ou click

		if (Input.GetButton ("Fire1")) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
             
			if (Physics.Raycast (ray, out hit)   ) {
                print(hit.collider.gameObject.tag);

                novaPosicao = hit.point;
                print(novaPosicao);
                transform.position = Vector3.MoveTowards (transform.position,  new Vector3(novaPosicao.x,0,novaPosicao.z), velocidade * Time.deltaTime);
               
                ani.CrossFade ("run");
                // transform.LookAt (hit.point);
                            
                /*
                Vector3 targetPostition = new Vector3(hit.point.x,
                                                       this.transform.position.y,
                                                       hit.point.z);
                this.transform.LookAt(targetPostition);
                */

            }

            // Create a vector from the player to the point on the floor the raycast from the mouse hit.
            Vector3 playerToMouse = hit.point - transform.position;

            // Ensure the vector is entirely along the floor plane.
            playerToMouse.y = 0f;

            // Create a quaternion (rotation) based on looking down the vector from the player to the mouse.
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

            // Set the player's rotation to this new rotation.
            playerRigidbody.MoveRotation(newRotation);
        } else {
			ani.CrossFade ("idle");
		}
	


	}
}
