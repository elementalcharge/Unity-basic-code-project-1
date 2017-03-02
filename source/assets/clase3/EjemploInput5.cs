using UnityEngine;
using System.Collections;

public class EjemploInput5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//devuelve true 1 vez cuando es presionada
		if(Input.GetButtonDown("Fire1")){
			print("Vida");

		}
		//devuelve true 1 vez cuando es soltada
		if(Input.GetButtonUp("Fire1")){
			print("Victoria o muerte D:");
			
		}
	}
}
