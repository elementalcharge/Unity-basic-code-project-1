using UnityEngine;
using System.Collections;

public class TareaIfAnidados : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("TeclaJ")) {
			if(Input.GetButton ("TeclaK")){
				if(Input.GetButton ("TeclaL"))
				{
					print ("You did it");
				}
				else{
					print("close But NO CIGAR");
				}
			}
			else{
				print("Still NOPE");
			}
		} else {
			print("nope");
		}
	
		if (Input.GetButton ("TeclaJ") && (Input.GetButton ("TeclaL"))) {
			print("who Showed you this");
		}
		if (Input.GetButton ("TeclaJ") || (Input.GetButton ("TeclaK"))) {
			print("im here to make conflict");
		}

	}
}
