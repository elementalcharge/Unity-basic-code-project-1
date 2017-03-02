using UnityEngine;
using System.Collections;

public class vidaEnemigo : MonoBehaviour {

	
	public float hp;
	public GameObject Muerte;
	public int valorpuntos;
	

	public void takeDamage(float damage){
		
		hp -= damage;
		if (hp <= 0) {
			GameObject mgrGo = GameObject.Find("GameManager");
			manejoDelJuego mgr = mgrGo.GetComponent<manejoDelJuego>();
			mgr.sumarPuntos (valorpuntos);
			Destroy(gameObject);
		}
		print ("hurted!"+hp);
	}

	
	void OnDestroy(){
		//	if (vida <= 0) {

		Instantiate (Muerte, transform.position + transform.up * 4, transform.rotation);
		//	}
	}
}
