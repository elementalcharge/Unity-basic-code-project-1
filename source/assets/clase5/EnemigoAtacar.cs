using UnityEngine;
using System.Collections;

public class EnemigoAtacar : MonoBehaviour {
	//public Random randomizer= new Random();
	//private int probable;
	// Use this for initialization
	public float tiempoParaDisparar;
	public GameObject Balas;
	public Transform spawn;
	private float contador;
	void Awake () {
		//Instantiate (Balas,transform.position+transform.forward*5+transform.up*3,transform.rotation);
		//probable = randomizer.Next(5,10);
	}
	
	// Update is called once per frame transform.position+transform.forward*5+transform.up*3
	void Update () {
		if(tiempoParaDisparar<contador){
			Instantiate (Balas,spawn.position,transform.rotation);
			contador=0;
		}
		else{
			contador+=Time.deltaTime;
		}
	}
}
