using UnityEngine;
using System.Collections;

public class TriggerSpawn : MonoBehaviour {
	public bool triggered;
	public GameObject Trap;
	void OnTriggerEnter(Collider col)
	{
		if(triggered==false&&col.gameObject.layer==9)
		{
		Instantiate (Trap, transform.position , transform.rotation);
		triggered=true;
		}
	}
}
