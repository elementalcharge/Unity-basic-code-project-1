using UnityEngine;
using System.Collections;

public class OnDestroyDo : MonoBehaviour {
	public GameObject spawnedObject;
	// Use this for initialization
	void Start () {
	
	}
	void OnDestroy(){
		Instantiate (spawnedObject,transform.position,transform.rotation);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
