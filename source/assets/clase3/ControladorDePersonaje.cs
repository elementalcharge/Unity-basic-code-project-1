using UnityEngine;
using System.Collections;

public class ControladorDePersonaje : MonoBehaviour {

	// Use this for initialization
	public string Xaxis;
	public string zaxis;
	public string rotationAxis;
	public bool invertirAxis;
	public string YaxisSalto;
	public int velocidad;
	/*private Animator anim;
	// Update is called once per frame
	void Start()
	{
		GameObject jugador=  GameObject.Find("player 1 1");
			 anim= jugador.GetComponent<Animator>();
	}*/
	void Update () {
		transform.Translate (Input.GetAxis (Xaxis) * velocidad * Time.deltaTime
		                    , Input.GetAxis (YaxisSalto) * velocidad * Time.deltaTime
		                     ,Input.GetAxis (zaxis) * velocidad * Time.deltaTime);
		transform.Rotate(0,Input.GetAxis(rotationAxis)*Time.deltaTime*50,0);
		//print(""+Input.GetAxis(RotationAxis));
		//anim.CrossFade("Walk",0.5f);

		
	}
}
