using UnityEngine;
using System.Collections;

public class vidaDePersonaje : MonoBehaviour 
{
	public float vida;
	public float vidamax;
	private Vector3 originalPosition;
	
	public GameObject desactivoAlmorir;
	void Awake()
	{
		vidamax = vida;
		originalPosition = transform.position;
	}
	void Update()
	{

	}

	public void fullyrestore ()
	{
		vida = vidamax;
	}
	public void respawn()
	{
		transform.position = originalPosition;

		
	}
	public void takeDamage(float dam){
		if(vida>vidamax)
		{
			vida=vidamax;

		}
		vida -= dam;
		if (vida <= 0) 
			{
				SendMessage("Messagedead", SendMessageOptions.RequireReceiver);
				//Destroy(this);
			/*if(player==true)
				{
			//desactivoAlmorir.SetActive(false);
				GameObject managerFinder = GameObject.Find("GameManager");
				manejoDelJuego playerlife = managerFinder.GetComponent<manejoDelJuego>();
				playerlife.SendMessage ("Messagedead", SendMessageOptions.RequireReceiver);
			
				print("you are dead");
			//Destroy (gameObject);
				}
			else
				{
				GameObject mgrGo = GameObject.Find("GameManager");
				manejoDelJuego mgr = mgrGo.GetComponent<manejoDelJuego>();
				mgr.sumarPuntos (valorpuntos);

				}*/
			}
		//print ("ejecutado el metodo");
	}

	/*
	void OnCollisionEnter(collision col){
		//col.gameObject;
		vida-=1;
		print("im hit!");
		//Destroy(gameObject);
		if (vida <= 0) {

		}
	}*/
	/*
	void OnCollisionExit(){
		vida-=1;
		print("im hit!");
		//Destroy(gameObject);
		if (vida <= 0) {
			Destroy(gameObject);
		}
	}*/

	
}
