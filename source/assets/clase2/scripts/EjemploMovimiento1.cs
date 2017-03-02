using UnityEngine;
using System.Collections;

public class EjemploMovimiento1 : MonoBehaviour {

	void Awake (){

		transform.Translate (0, 0, 1);
	}
	void Update(){
		transform.Translate (1, 1, 1);
		transform.Rotate (0, 1, 9);
	}

}
