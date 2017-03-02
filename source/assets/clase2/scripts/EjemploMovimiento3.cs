using UnityEngine;
using System.Collections;

public class EjemploMovimiento3 : MonoBehaviour {
	public Vector3 punto;
	public Vector3 axis;

	void Update () {
		transform.RotateAround (punto, axis, 30*Time.deltaTime);

	}
}
