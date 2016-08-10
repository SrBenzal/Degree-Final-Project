using UnityEngine;
using System.Collections;

public class Draw : MonoBehaviour {

	ColorsLevelManager Manager;
	bool selected;
	// Use this for initialization
	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();
	}

	void OnTriggerEnter(Collider other) {
		selected = true;
		Debug.Log ("SS");
	}

	void OnTriggerExit(Collider other) {
		selected = false;
	}

	void paint(){
		GetComponent<Renderer> ().material.color = Manager.selectedColor;
	}

	// Update is called once per frame
	void Update () {
		if (selected && Input.GetKeyDown (KeyCode.Space)) {
			paint ();
		}
	}
}
