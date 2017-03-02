using UnityEngine;
using System.Collections;

public class ControladorDePersonaje2 : MonoBehaviour {

	public int velocidad;
	public string Xaxis= "HorizontalL";
	public string Yaxis ="VerticalK";
	public string Xaxis2= "HorizontalJ";
	public string Yaxis2 ="VerticalI";

	public string ZaxisSalto ="Fire2";

	// Update is called once per frame
	void Update () {
		if(Input.GetButton("HorizontalL")){
			transform.Translate (0,0,1);
		}
		if(Input.GetButton("HorizontalJ")){
			transform.Translate (0,0,-1);
		}
		if(Input.GetButton("VerticalI")){
			transform.Translate (1,0,0);
		}
		if(Input.GetButton("VerticalK")){
			transform.Translate (-1,0,0);
		}


	}
}
