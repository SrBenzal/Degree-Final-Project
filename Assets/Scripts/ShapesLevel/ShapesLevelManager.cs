using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShapesLevelManager : MonoBehaviour {

	public bool oneSelected=false;
	public TextMesh BallsLeftText, CubesLeftText, StarsLeftText, RombosLeftText;
	public int BallsLeft = 5, CubesLeft = 5, StarsLeft = 5, RombosLeft = 5; 

	public void updateText() {
		BallsLeftText.text = "" + BallsLeft;
		CubesLeftText.text = "" + CubesLeft;
		StarsLeftText.text = "" + StarsLeft;
		RombosLeftText.text = "" + RombosLeft;

		CheckEndLevel ();
	}

	void CheckEndLevel(){
		if (BallsLeft==0 && CubesLeft==0 && StarsLeft ==0 && RombosLeft==0) {
			Debug.Log ("Level Complete");
			SceneManager.LoadScene ("SelectionLevel");
		}
	}
}