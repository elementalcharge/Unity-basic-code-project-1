using UnityEngine;
using System.Collections;

public class AgrandamientoContinuo : MonoBehaviour {
	public float constanteDeCrecimiento;
	public float limiteCrecimiento;
	// Update is called once per frame
	void Update () 
	{
		Vector3 scale = transform.localScale;
		scale.x += constanteDeCrecimiento;
		scale.y += constanteDeCrecimiento;
		scale.z += constanteDeCrecimiento;
		transform.localScale = scale;
		if(scale.x>limiteCrecimiento || scale.x < limiteCrecimiento * -1 ){
			constanteDeCrecimiento*=-1;
		}

	}
}
