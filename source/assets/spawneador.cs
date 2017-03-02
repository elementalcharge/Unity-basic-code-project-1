using UnityEngine;
using System.Collections;

public class spawneador : MonoBehaviour {
	public GameObject spawncreature;
	// Use this for initialization
	public float timebeforeSpawn=10;
	private float timer=0;
	private int second=0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer<2 && timer>1)
		{
			print("iniciate spawn");
		}
		/*if(timer<2)
		{
			print("iniciate spawn");
		}*/
		second = Mathf.RoundToInt (timer);
		if(second%2==0){
			print("im working fine");
			//Instantiate(spawncreature,transform.position,transform.rotation);
		}
		//codigo de spawn real aca abajo
		if (timer > timebeforeSpawn) {
			timer=0;
			Instantiate(spawncreature,transform.position,transform.rotation);

		}

			
		/*WaitForSeconds(6){
			Instantiate(spawncreature,transform.position,Transform.rotation);
		}*/
	}

}
