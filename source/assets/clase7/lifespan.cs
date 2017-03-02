using UnityEngine;
using System.Collections;

public class lifespan : MonoBehaviour {

	public float lifeSpan;
	void Awake(){
		Destroy (gameObject, lifeSpan);
	}
	// Update is called once per frame
	/*void Update () {
		lifespan -= Time.deltaTime;
		if (lifespan <= 0) {
			Destroy(gameObject);
		}
	}
	*/
}
