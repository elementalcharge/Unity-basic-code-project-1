using UnityEngine;
using System.Collections;

public class ejemploColision1 : MonoBehaviour {

	void OnTriggerEnter(){
		print ("stop hitting me");
	}

	void OnTriggerStay(){
		print ("im inside you(creepy)");
	}
	void OnTriggerExit(){
		print ("No more");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
