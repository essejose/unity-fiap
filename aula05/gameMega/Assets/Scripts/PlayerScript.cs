using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	Animator animator;

	public float life;
	public float velocidade;
	public float impulso;

	public Transform chaoVerificador;
	public Transform chaoVerificadorEsqueda;
	public Transform chaoVerificadorDireita;

	bool estanoChao;
	bool intro = true;
	float intervalo = 0.1f;

	Rigidbody2D rb;

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
		StartCoroutine (start ());
	}
	
	// Update is called once per frame
	void Update () {


		mover ();


	}

	IEnumerator start(){
		animator.SetBool ("inGame", false);
		 
		yield return new WaitForSeconds (.5f);
		animator.SetBool ("inGame", true);
		intro = false;


	}

	void mover(){

		if (!intro) {
			float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
			transform.Translate (mover_x, 0.0f, 0.0f);

			if (mover_x > 0.0f) {
				spriteRenderer.flipX = false;

			} else if (mover_x < 0.0f) {
				spriteRenderer.flipX = true;

			}
			animator.SetFloat ("run", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));

			estanoChao = Physics2D.Linecast (transform.position, chaoVerificadorEsqueda.position, 1 << LayerMask.NameToLayer ("Piso")) || Physics2D.Linecast (transform.position, chaoVerificadorDireita.position, 1 << LayerMask.NameToLayer ("Piso"));
	 
			animator.SetBool ("jump", !estanoChao);
			if (estanoChao)
				pulo ();

			fire ();
		}
	}

	void pulo(){
		
		if (Input.GetButtonDown ("Jump")) {

			rb.velocity = new Vector2 (0.0f, impulso);

		}

	}

	void fire(){
		
		if (Input.GetButton("Fire1")) {

			animator.SetBool ("isFire", true);
		} else {
			animator.SetBool ("isFire", false);
		}
	}

	void OnTriggerEnter2D(Collider2D c) {
		 

		if (c.gameObject.tag == "subInimigo") {
			life--;

			StartCoroutine (blink());
		 
			if (life <= 0) {
				Destroy (gameObject);
			}

		}


	}


	IEnumerator blink(){

	 
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo); 
 
	 
	}


 




}
