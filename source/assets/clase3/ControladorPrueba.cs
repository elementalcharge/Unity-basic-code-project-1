using UnityEngine;
using System.Collections;

public class ControladorPrueba : MonoBehaviour {

	public int velocidad=2;
	public bool cubeOn=true;
	public string TeclaX ;
	public string TeclaY ;

	// Update is called once per frame
	void Update () {
	/*	if (Input.GetAxis("Fire1")!=0) {
			if(cubeOn==false)cubeOn=true;
			if(cubeOn==true)cubeOn=false;

		}*/
		//if(cubeOn){
		transform.Translate (Input.GetAxis (TeclaX)*Time.deltaTime*velocidad, 0, velocidad*Input.GetAxis (TeclaY)*Time.deltaTime);

		//}
	}
}
