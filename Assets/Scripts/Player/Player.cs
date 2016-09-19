using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	ColorsLevelManager Manager;

	float speed = 0.5f;

	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();

	}
	
	void Update () {
		float UpDown = Input.GetAxis("Vertical") * speed;
		float LeftRight = Input.GetAxis("Horizontal") * speed;

		transform.Translate(LeftRight, 0, UpDown);
	}

}
