using UnityEngine;
using System.Collections;

public class MuerteEnemigo : MonoBehaviour {
	public GameObject Muerte;
	public int valorpuntos;
	public void Messagedead()
	{
		GameObject mgrGo = GameObject.Find("GameManager");
			manejoDelJuego mgr = mgrGo.GetComponent<manejoDelJuego>();
			mgr.sumarPuntos (valorpuntos);
			Destroy(gameObject);
			if(Muerte!=null)
			{
				Instantiate (Muerte, transform.position + transform.up * 4, transform.rotation);
			}
	}
	void OnDestroy(){
		//	if (vida <= 0) {

		
		//	}
	}
}
