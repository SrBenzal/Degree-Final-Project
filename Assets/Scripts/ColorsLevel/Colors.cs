using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour {

	ColorsLevelManager Manager;

	// Use this for initialization
	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();
	}

	void OnTriggerEnter(Collider other) {
		Manager.selectedColor = GetComponent<Renderer> ().material.color;
		Debug.Log (Manager.selectedColor);
	}
}
