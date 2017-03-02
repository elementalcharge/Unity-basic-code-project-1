using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	public int vida;
	public GameObject Muerte;

	void OnCollisionEnter(Collision col){

		vida-=1;
		print("im hit!");
		//Destroy(gameObject);
		if (vida <= 0) {
			Destroy(gameObject);
		}
	}
	void OnCollisionExit(){
		vida-=1;
		print("im hit!");
		//Destroy(gameObject);
		if (vida <= 0) {
			Destroy(gameObject);
		}
	}

	void OnDestroy(){
	//	if (vida <= 0) {
			Instantiate (Muerte, transform.position + transform.up * 4, transform.rotation);
	//	}
	}
}
