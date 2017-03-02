using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LifeBarController : MonoBehaviour {
	public Image lifebar;
	//public float characterLife;
	private float characterFullLife;
	//public Text charactNameLabel;
	//public string charactName;
	private vidaDePersonaje vidaP;

	void Awake(){
		GameObject jugador = GameObject.Find ("player 1 1");
		vidaP = jugador.GetComponent<vidaDePersonaje> ();
		characterFullLife = vidaP.vida;
		//charactNameLabel.text = charactName;
	}
	// Update is called once per frame
	void Update () 
	{
			lifebar.fillAmount=vidaP.vida/characterFullLife;
	}
}
