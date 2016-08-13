using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Emphasis : MonoBehaviour {

	GameObject[] panels;
	// Use this for initialization
	void Start () {
		panels = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			panels [i] = transform.GetChild (i).gameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void makeImageBrighter(int i){
		panels [i].GetComponent<Image> ().color = Color.white;
	}

	public void makeImageDarker(int i){
		//panels [i].GetComponent<Image> ().color = Color.gray;
		panels [i].GetComponent<Image> ().color = new Color(0.75f,0.75f,0.75f,1);
	}
}
