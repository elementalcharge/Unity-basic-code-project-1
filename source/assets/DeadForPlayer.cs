using UnityEngine;
using System.Collections;

public class DeadForPlayer : MonoBehaviour {

	public void Messagedead()
	{
		GameObject managerFinder = GameObject.Find("GameManager");
		manejoDelJuego playerlife = managerFinder.GetComponent<manejoDelJuego>();
		playerlife.Messagedead();
	}
}
