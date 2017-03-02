using UnityEngine;
using System.Collections;

public class RotacionYMovimientoContinuo : MonoBehaviour {

	public Vector3 VectorRotacion;
	public Vector3 VectorMovimiento;
	// Update is called once per frame
	void Update () {
		transform.Translate (VectorMovimiento*Time.deltaTime);
		transform.Rotate (VectorRotacion*Time.deltaTime);
	
	}
}
