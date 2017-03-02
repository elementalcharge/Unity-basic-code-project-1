using UnityEngine;
using System.Collections;

public class monsterSpawn : MonoBehaviour {
	private float timepassed;
	public float timeToSpawn;
	public GameObject enemy;
	public GameObject smoke;
	// Use this for initialization
	void Start ()
	 {
		timepassed=0;
	}
	
	// Update is called once per frame
	void Update () {
	
		timepassed+=Time.deltaTime;
		if(timepassed>timeToSpawn)
		{
			Instantiate(enemy,transform.position,transform.rotation);
			Instantiate(smoke,transform.position,transform.rotation);
			timepassed=0;
		}
	}
}
