using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Emphasis : MonoBehaviour {

	GameObject[] panels;

	void Start () {
		panels = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			panels [i] = transform.GetChild (i).gameObject;
		}
	}

	public void makeImageBrighter(int i){
		panels [i].GetComponent<Image> ().color = Color.white;
	}

	public void makeImageDarker(int i){
		panels [i].GetComponent<Image> ().color = new Color(0.5f,0.5f,0.5f,1);
	}
}
