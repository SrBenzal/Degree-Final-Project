using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour {

    AnimalsLevelManager Manager;
    public int ID;
    // Use this for initialization
    void Start () {
        Manager = FindObjectOfType<AnimalsLevelManager>();
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
			Manager.animalSelected = this.name;//(GetComponentInChildren<TextMesh>().text);
            Manager.checkSelected();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
