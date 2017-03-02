using UnityEngine;
using System.Collections;

public class EjemploMensaje1 : MonoBehaviour 
{
	public void Messagedead()
	{	
		GameObject managerFinder = GameObject.Find("GameManager");
		manejoDelJuego playerlife = managerFinder.GetComponent<manejoDelJuego>();
		playerlife.Messagedead();
	}
}
