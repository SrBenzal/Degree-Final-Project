using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour {

    NumbersLevelManager Manager;

    void OnTriggerEnter(Collider other)
    {
    }

    void OnTriggerExit(Collider other)
    {
    }

    void OnTriggerStay(Collider other) {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Manager.numberSelected = int.Parse(GetComponentInChildren<TextMesh>().text);
            Manager.checkSelected();
        }
    }

    // Use this for initialization
    void Start () {
        Manager = FindObjectOfType<NumbersLevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
