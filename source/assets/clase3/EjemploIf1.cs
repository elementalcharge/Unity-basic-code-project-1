using UnityEngine;
using System.Collections;

public class EjemploIf1 : MonoBehaviour {

	public bool booleano;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire1")) {
			transform.Translate (10, 0, 0);
		}
		else {
			transform.Translate(-10,0,0);
		}
		/*if (booleano) {
			print("hola!)");
		}
		else {
			print("chau!(");
		}*/
	}
}
