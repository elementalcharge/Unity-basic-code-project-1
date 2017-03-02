using UnityEngine;
using System.Collections;

public class buyStationmenu : MonoBehaviour {
	public AudioSource sonidoTienda;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerStay(){
		if(Input.GetButtonDown("Jump")){
			sonidoTienda.Play();
		}
		if(Input.GetButtonUp("Jump")){
			sonidoTienda.Stop();
		}

	}
	void OnTriggerExit(){
		sonidoTienda.Stop();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
