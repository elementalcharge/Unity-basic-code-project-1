using UnityEngine;
using System.Collections;

public class SceneSwap : MonoBehaviour {
	public string newScene;
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.layer==9)
		{
			SendMessage("LoadScene",newScene , SendMessageOptions.RequireReceiver);
		}
	}
	
}
