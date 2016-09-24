﻿using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour {

	ColorsLevelManager Manager;
	public int ID;
	public Color color;

	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();
	}

	void OnTriggerStay(Collider other) {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			color = GetComponent<Renderer> ().material.color;
			Manager.selectedColor = this;
			Debug.Log (Manager.selectedColor);
		}
		if (Input.GetKeyDown(KeyCode.H)) {
			GetComponent<AudioSource> ().Play ();
		}
	}
}
