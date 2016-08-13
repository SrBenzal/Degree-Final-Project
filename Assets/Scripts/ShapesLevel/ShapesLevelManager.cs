using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShapesLevelManager : MonoBehaviour {

    public bool oneSelected=false;
    public TextMesh BallsLeftText, CubesLeftText, StarsLeftText, RombosLeftText;
    public int BallsLeft = 5, CubesLeft = 5, StarsLeft = 5, RombosLeft = 5; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void updateText() {
        BallsLeftText.text = "" + BallsLeft;
        CubesLeftText.text = "" + CubesLeft;
        StarsLeftText.text = "" + StarsLeft;
        RombosLeftText.text = "" + RombosLeft;
    }
}
