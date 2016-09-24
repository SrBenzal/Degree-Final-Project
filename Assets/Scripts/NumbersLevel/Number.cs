using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour {

    NumbersLevelManager Manager;

    void OnTriggerStay(Collider other) {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Manager.numberSelected = int.Parse(GetComponentInChildren<TextMesh>().text);
            Manager.checkSelected();
        }
		if (Input.GetKeyDown(KeyCode.H)) {
			if (!Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().isPlaying)
				Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource> ().Play ();
		}
    }

	void OnTriggerExit(Collider other){
		if (Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().isPlaying)
			Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource> ().Stop ();
	}
		
    void Start () {
        Manager = FindObjectOfType<NumbersLevelManager>();
	}
}