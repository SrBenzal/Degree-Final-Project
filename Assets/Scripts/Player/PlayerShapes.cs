using UnityEngine;
using System.Collections;

public class PlayerShapes : MonoBehaviour {

	ColorsLevelManager Manager;

	float speed = 0.5f;
	// Use this for initialization
	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();

	}

	// Update is called once per frame
	void Update () {
		float UpDown = Input.GetAxis("Vertical") * speed;
		float LeftRight = Input.GetAxis("Horizontal") * speed;

		transform.Translate(LeftRight, 0, UpDown);
	}

	/*void onEnterTrigger(Collider other){
		Manager.selectedColor = GetComponent<Renderer> ().material.color;
		Debug.Log (Manager.selectedColor);
	}*/
}
