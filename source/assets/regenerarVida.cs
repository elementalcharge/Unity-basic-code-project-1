using UnityEngine;
using System.Collections;

public class regenerarVida : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision col){
		//GameObject chocador=col.gameObject;
		vidaDePersonaje energia=col.gameObject.GetComponent<vidaDePersonaje>();
		if(energia!=null){
			print("alive");
			energia.vida += 10;
		}
		Destroy (gameObject);
	}
}
