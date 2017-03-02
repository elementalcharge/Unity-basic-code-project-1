using UnityEngine;
using System.Collections;

public class dañarPersonaje : MonoBehaviour {
	public float damageQty;
	void OnCollisionEnter(Collision col)
	{

		vidaDePersonaje component=	col.gameObject.GetComponent<vidaDePersonaje> ();
		if (component != null) {
			component.takeDamage(damageQty);


		}
		/*
		switch (col.gameObject.layer) {
		case 9:print("tocado por pinche");
			break;
		default:print("algo mas");
			break;
		}
		if (col.gameObject.layer == 8) {
			print("tocado por bala");
		}*/
	}
}
