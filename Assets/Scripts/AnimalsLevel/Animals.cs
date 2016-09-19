using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour {

    AnimalsLevelManager Manager;

    void Start () {
        Manager = FindObjectOfType<AnimalsLevelManager>();
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
			Manager.animalSelected = this.name;
            Manager.checkSelected();
        }
    }
}
