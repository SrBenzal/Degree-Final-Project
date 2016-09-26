using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour {

    AnimalsLevelManager Manager;
    public int ID;
    bool music = false, bend=false;

    // Use this for initialization
    void Start () {
        Manager = FindObjectOfType<AnimalsLevelManager>();
        
    }

    void OnTriggerStay(Collider other)
    {
        if (!music)
        {
            if (Manager.player.RightHandUp())
            {
                GetComponent<AudioSource>().Play();
                music = true;
            }

            if (Manager.player.ClapHands())
            {
                Manager.animalSelected = this.name;
                Manager.checkSelected();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Manager.animalSelected = this.name;
                Manager.checkSelected();
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                GetComponent<AudioSource>().Play();
				music = true;
            }
        }
        else
        {
            if (!GetComponent<AudioSource>().isPlaying)
            {
                music = false;
            }
        }
    }
}
