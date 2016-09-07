using UnityEngine;
using System.Collections;

public class CreateColors : MonoBehaviour {

	// Use this for initialization

	Color[] colors;
	void Start () {
		colors = new Color[transform.childCount];
		colors [0] = Color.red;
		colors [1] = Color.yellow;
		colors [2] = Color.green;
		colors [3] = Color.blue;
		colors [4] = new Color (1f, 0.55f, 0f); //Orange
		colors [5] = Color.magenta;
		colors [6] = new Color(0.54f,0.27f,0.17f); //Brown
		colors [7] = Color.white;
		paintBalls();
	}

	void paintBalls(){
		for (int i = 0; i < transform.childCount; i++) {
			transform.GetChild (i).gameObject.GetComponent<Renderer> ().material.color = colors [i];
		}
	}
}
