using UnityEngine;
using System.Collections;

public class collisionDiscriminadora : MonoBehaviour 
{
	public float damageQty;

	/*void OnCollisionEnter()
	{
		print ("blah");
	}*/


	void OnCollisionEnter(Collision col)
	{

		vidaDePersonaje component=	col.gameObject.GetComponent<vidaDePersonaje> ();
		if (component != null) {
			component.takeDamage(damageQty);
			print("colisiono"+col.gameObject.layer);
		}

		switch (col.gameObject.layer) {
		case 12:Destroy(gameObject);
			break;
		default:print("algo mas");
			break;
		}
		if (col.gameObject.layer == 8) {
			print("tocado por bala");
		}
	}
	// Update is called once per frame

}
