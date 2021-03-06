﻿
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

            if (Manager.player.ClapHands())
            {
                color = GetComponent<Renderer>().material.color;
                Manager.player.gameObject.GetComponent<Renderer>().material.color = color;
                Manager.selectedColor = this;
                Debug.Log(Manager.selectedColor);

            }

			if (Input.GetKeyDown(KeyCode.Space))
	        {
				color = GetComponent<Renderer>().material.color;
				Manager.player.gameObject.GetComponent<Renderer>().material.color = color;
				Manager.selectedColor = this;
				Debug.Log(Manager.selectedColor);
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