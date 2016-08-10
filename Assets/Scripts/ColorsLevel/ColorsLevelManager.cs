using UnityEngine;
using System.Collections;

public class ColorsLevelManager : MonoBehaviour {

	// Use this for initialization
	public Color selectedColor;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (selectedColor);
	}



	/*public void selectColor(GameObject g){
		Debug.Log ("d2");

		selectedColor = g.GetComponent<Renderer> ().material.color;
		Debug.Log (selectedColor);
	}*/
}
