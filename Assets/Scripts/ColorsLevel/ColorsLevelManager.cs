using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColorsLevelManager : MonoBehaviour {

	public Colors selectedColor;
	public GameObject[] drawParts;

	public int parts;
	public int rightColors=0;
	void Start () {
	}

	public void checkFinishLevel(){
		if (rightColors==parts) {
			Debug.Log ("Level Complete");
			SceneManager.LoadScene ("SelectionLevel");
		}
	}
}
