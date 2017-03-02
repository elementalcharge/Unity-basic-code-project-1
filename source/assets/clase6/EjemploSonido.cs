using UnityEngine;
using System.Collections;

public class EjemploSonido : MonoBehaviour {


	public AudioSource sonido;

	void Update(){
		if (Input.GetButtonUp ("Fire1")) {
			sonido.Stop();
		}
		
		if (Input.GetButtonDown ("Fire1")) {
			sonido.Play();
		}
	}
}
