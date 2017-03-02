using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class vidasDelpjEnPantalla : MonoBehaviour {
	private int vidaspj;
	private manejoDelJuego controler;
	public Text vidas;
	// Use this for initialization
	void Start () {
		GameObject jugador = GameObject.Find ("GameManager");
		controler= jugador.GetComponent<manejoDelJuego> ();
		vidaspj = controler.vidas;
	}
	
	// Update is called once per frame
	void Update () {
		vidaspj = controler.vidas;
		vidas.text = "Vidas:  " + vidaspj;
	}
}
