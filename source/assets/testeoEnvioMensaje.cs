using UnityEngine;
using System.Collections;

public class testeoEnvioMensaje : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
		{
			SendMessage("Upd1",SendMessageOptions.DontRequireReceiver);
			SendMessage("Mensaje1", SendMessageOptions.DontRequireReceiver);
		}
	}
}
