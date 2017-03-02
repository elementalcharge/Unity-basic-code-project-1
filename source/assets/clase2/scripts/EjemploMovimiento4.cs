using UnityEngine;
using System.Collections;

public class EjemploMovimiento4 : MonoBehaviour {

	public float velocidad;
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, velocidad * Time.deltaTime);
	}
}
