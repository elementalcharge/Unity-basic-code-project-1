using UnityEngine;
using System.Collections;

public class MovimientoContinuo : MonoBehaviour {

	public float movX;
	public float movY;
	public float movZ;

	// Update is called once per frame
	void Update () {
		transform.Translate (movX*Time.deltaTime, movY*Time.deltaTime, movZ*Time.deltaTime);

	}
}
