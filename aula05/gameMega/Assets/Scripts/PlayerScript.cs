using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	Animator animator;

	public float velocidade;
	public float impulso;
	public Transform chaoVerificador;

	bool estanoChao;

	Rigidbody2D rb;

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {


		mover ();


	}

	void mover(){
		
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		if (mover_x > 0.0f)
		{
			spriteRenderer.flipX = false;

		}
		else if( mover_x < 0.0f)  
		{
			spriteRenderer.flipX = true;

		}
		animator.SetFloat ("run", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));

		estanoChao = Physics2D.Linecast (transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Piso"));
		print (estanoChao);

		animator.SetBool ("jump", !estanoChao);
		if(estanoChao)
			pulo ();

		fire ();

	}

	void pulo(){
		
		if (Input.GetButtonDown ("Jump")) {

			rb.velocity = new Vector2 (0.0f, impulso);

		}

	}

	void fire(){
		
		if (Input.GetButton ("Fire1")) {

			animator.SetBool ("isFire", true);
		} else {
			animator.SetBool ("isFire", false);
		}
	}
}
