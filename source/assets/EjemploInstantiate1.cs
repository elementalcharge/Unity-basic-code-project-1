﻿using UnityEngine;
using System.Collections;

public class EjemploInstantiate2 : MonoBehaviour {
	public GameObject prefabElegido;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			Instantiate(prefabElegido,transform.position+transform.forward+transform.up,transform.rotation);
		}
	}
}
