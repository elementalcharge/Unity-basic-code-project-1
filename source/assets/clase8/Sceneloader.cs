using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Sceneloader : MonoBehaviour {

	public void LoadScene(string sceneName){
		Application.LoadLevel (sceneName);
	}
	// Update is called once per frame

}
