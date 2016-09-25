
using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour
{

    ColorsLevelManager Manager;
    public int ID;
    public Color color;
    bool music = false;

    void Start()
    {
        Manager = FindObjectOfType<ColorsLevelManager>();
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

            if (Manager.player.LeftHandUp())
            {
                color = GetComponent<Renderer>().material.color;
                Manager.selectedColor = this;
                Debug.Log(Manager.selectedColor);

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

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            color = GetComponent<Renderer>().material.color;
            Manager.selectedColor = this;
            Debug.Log(Manager.selectedColor);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("S");
        }*/
    }
}