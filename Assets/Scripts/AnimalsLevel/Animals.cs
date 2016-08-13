using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour {

    AnimalsLevelManager Manager;

    // Use this for initialization
    void Start () {
        Manager = FindObjectOfType<AnimalsLevelManager>();
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Manager.animalSelected = (GetComponentInChildren<TextMesh>().text);
            Manager.checkSelected();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
