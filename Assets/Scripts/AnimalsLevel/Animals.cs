using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour {

    AnimalsLevelManager Manager;
<<<<<<< HEAD

=======
    public int ID;
    // Use this for initialization
>>>>>>> origin/master
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
<<<<<<< HEAD
		if (Input.GetKeyDown(KeyCode.H)) {
			GetComponent<AudioSource> ().Play ();
		}
=======
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();
        }
>>>>>>> origin/master
    }
}
