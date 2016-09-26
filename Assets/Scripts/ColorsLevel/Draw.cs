using UnityEngine;
using System.Collections;

public class Draw : MonoBehaviour
{
    ColorsLevelManager Manager;
    bool selected;
    bool locked = false;
    public int ID;
    // Use this for initialization
    void Start()
    {
        Manager = FindObjectOfType<ColorsLevelManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        selected = true;
    }

    void OnTriggerExit(Collider other)
    {
        selected = false;
    }

	void paint(){
		GetComponent<Renderer> ().material.color = Manager.selectedColor.color;
	}

	void Update () {
		if (selected && Input.GetKeyDown (KeyCode.Space) && !locked) {
			if (Manager.selectedColor != null) {
				if (Manager.selectedColor.ID == this.ID) {
					locked = true;
					Manager.rightColors++;
				}
				paint ();
				Manager.checkFinishLevel ();
			}
		}

        if (selected && Manager.player.ClapHands() && !locked)
        {
            if (Manager.selectedColor!=null)
                {
                if (Manager.selectedColor.ID == this.ID)
                {
                    locked = true;
                    Manager.rightColors++;
                }
                paint();
                Manager.checkFinishLevel();
            }
        }
    }
}
