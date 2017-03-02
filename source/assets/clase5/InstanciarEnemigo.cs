using UnityEngine;
using System.Collections;

public class InstanciarEnemigo : MonoBehaviour {
	public GameObject Enemigo;
	// Use this for initialization
	void Start () {
		//print("esto anda");
	}
	void OnTriggerEnter(){
		Instantiate (Enemigo, transform.forward*20,transform.rotation);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
