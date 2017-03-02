using UnityEngine;
using System.Collections;

public class EjemploMovimiento2 : MonoBehaviour {

	public float moverZ=0;
	public float moverY=0;
	public float moverX=0;

	//Time.deltaTime nos da la cantidad de segundos que pasan entre frame y frame
	// Update is called once per frame
	void Update () {
		transform.Translate (moverX, moverY*Time.deltaTime, moverZ*Time.deltaTime, Space.World);
	}
}
