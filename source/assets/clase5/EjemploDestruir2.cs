using UnityEngine;
using System.Collections;

public class EjemploDestruir2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public GameObject spawnedObject;
	/*void OnTriggerEnter(){
		Destroy (gameObject);
	}*/
	void OnCollisionEnter(){
		Destroy (gameObject);
		Instantiate (spawnedObject,transform.position,transform.rotation);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
