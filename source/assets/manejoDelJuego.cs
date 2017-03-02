using UnityEngine;
using System.Collections;

public class manejoDelJuego : MonoBehaviour {
	public int vidas;
	public int puntos;
	public int puntosParaGanar;

	// Use this for initialization
	void Start () {
		//GameObject managerGeneral = GameObject.Find ("gamemanagerObject");
	}
	
	// Update is called once per frame
	void Update () {
	
		//SendMessage ("mensagedead", SendMessageOptions.DontRequireReceiver);
	}
	public void Messagedead()
	{
		print ("message received");
		vidas -= 1;
		GameObject playerfinder = GameObject.Find("player 1 1");
		vidaDePersonaje playerlife = playerfinder.GetComponent<vidaDePersonaje>();
		playerlife.fullyrestore ();
		playerlife.respawn ();
		if (vidas >= 0) {
			playerlife.desactivoAlmorir.SetActive (true);
		}
		else 
		{playerlife.desactivoAlmorir.SetActive (false);
		}
	

	}
	public void sumarPuntos(int puntosagregados)
	{
		puntos += puntosagregados;
		if(puntos>puntosParaGanar)
			{
				//instantiate();

			}	
		}
}
