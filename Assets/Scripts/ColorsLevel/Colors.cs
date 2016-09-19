using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour {

	ColorsLevelManager Manager;
	public int ID;
	public Color color;

	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();
	}

	void OnTriggerEnter(Collider other) {
		color = GetComponent<Renderer> ().material.color;
		Manager.selectedColor = this;
		Debug.Log (Manager.selectedColor);
	}
}
