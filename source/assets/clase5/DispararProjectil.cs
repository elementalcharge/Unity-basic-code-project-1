using UnityEngine;
using System.Collections;

public class DispararProjectil : MonoBehaviour {
	public GameObject prefabbullet;
	public float cadaCuantoDisparo;
	private float tiempopasado;
	private Animator anim;
	// Use this for initialization
	void Start () {
		tiempopasado=0;
		GameObject jugador=  GameObject.Find("player 1 1");
			 anim= jugador.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetButtonDown ("Jump")) {
			Instantiate(prefabbullet,transform.position+transform.up*2+transform.forward*2,transform.rotation);
		}*/
		//print ("" + tiempopasado+Input.GetButton("Jump"));
		tiempopasado+= Time.deltaTime;
		if (Input.GetButton("Jump") && tiempopasado >= cadaCuantoDisparo) 
		{
			
			anim.CrossFade("Lumbering",1.5f);
			
			Instantiate(prefabbullet,transform.position+transform.up*2+transform.forward*2,transform.rotation);
			tiempopasado=0;
			anim.CrossFade("Walk",1.5f);
		}
		

	}
	
}
