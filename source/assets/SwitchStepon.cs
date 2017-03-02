using UnityEngine;
using System.Collections;

public class SwitchStepon : MonoBehaviour {

	public bool triggered;
	
	void OnTriggerEnter(Collider col)
	{
		if(triggered==false&&col.gameObject.layer==9)
		{
		triggered=true;
		Destroy(gameObject);
		}
	}
}
