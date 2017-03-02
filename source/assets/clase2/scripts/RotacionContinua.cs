using UnityEngine;
using System.Collections;

public class RotacionContinua : MonoBehaviour {

	public Vector3 vectorDeRotacion;//en que axis quiero que gire

	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (vector, angulo);
		transform.Rotate (vectorDeRotacion.x*Time.deltaTime, vectorDeRotacion.y*Time.deltaTime, vectorDeRotacion.z*Time.deltaTime);

	}
}
