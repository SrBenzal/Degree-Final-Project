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
        Debug.Log(music);
        if (!music)
        {
            if (Manager.player.RightHandUp())
            {
                GetComponent<AudioSource>().Play();
                music = true;
            }

            if (Manager.player.Bend())
            {
                Manager.animalSelected = this.name;
                Manager.checkSelected();
            }

            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                Manager.animalSelected = this.name;
                Manager.checkSelected();
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                GetComponent<AudioSource>().Play();
            }*/
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
