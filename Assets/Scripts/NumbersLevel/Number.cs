using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour
{

    NumbersLevelManager Manager;
    bool music = false;
    void OnTriggerStay(Collider other)
    {
        if (!music)
        {
            if (Manager.player.RightHandUp())
            {
                if (!Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().isPlaying)
                    Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().Play();
                music = true;
            }

            if (Manager.player.ClapHands())
            {
                Manager.numberSelected = int.Parse(GetComponentInChildren<TextMesh>().text);
                Manager.checkSelected();

            }

			if (Input.GetKeyDown(KeyCode.Space))
			{
				Manager.numberSelected = int.Parse(GetComponentInChildren<TextMesh>().text);
				Manager.checkSelected();
			}
			if (Input.GetKeyDown(KeyCode.H))
			{
				if (!Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().isPlaying)
					Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().Play();
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Manager.numberSelected = int.Parse(GetComponentInChildren<TextMesh>().text);
            Manager.checkSelected();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().isPlaying)
                Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().isPlaying)
            Manager.numbersPanels[int.Parse(this.GetComponentInChildren<TextMesh>().text)].GetComponent<AudioSource>().Stop();
    }

    void Start()
    {
        Manager = FindObjectOfType<NumbersLevelManager>();
    }
}