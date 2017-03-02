using UnityEngine;
using System.Collections;

public class movableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerStay(){
		transform.Translate(0,0,1*Time.deltaTime);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
