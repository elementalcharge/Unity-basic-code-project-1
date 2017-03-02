using UnityEngine;
using System.Collections;

public class InfiniteRunController : MonoBehaviour {

	public float DefaultSpeed=10;
	public float turboSpeed=10;
	public float multiplier=1;
	//public float accelerator=0.01f;
	public string Xaxis="Horizontal";
	

	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			multiplier*=turboSpeed;
		}
		if(Input.GetButtonUp("Fire1")){
			multiplier/=turboSpeed;
		}


		transform.Translate ((Input.GetAxis (Xaxis)+DefaultSpeed )* (multiplier) * Time.deltaTime
		                     , 0 * Time.deltaTime
		                     , 0 * Time.deltaTime);
	}
}
