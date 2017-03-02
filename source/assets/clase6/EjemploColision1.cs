using UnityEngine;
using System.Collections;

public class EjemploColision1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(){
		print ("trigger");
	}
	void OnCollisionEnter(){
		print ("collision");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
