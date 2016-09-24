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
    }
		
    void Start () {
        Manager = FindObjectOfType<NumbersLevelManager>();
	}
}