using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour {
	public float hp;
	public void takeDamage(float damage){

		hp -= damage;
		if (hp <= 0) {
			Destroy(gameObject);
		}
		print ("hurted!"+hp);
	}
	public void Awake(){
		hp=10;
	}

}

