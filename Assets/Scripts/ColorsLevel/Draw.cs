using UnityEngine;
using System.Collections;

public class Draw : MonoBehaviour
{

<<<<<<< HEAD
	ColorsLevelManager Manager;
	bool selected;
	bool locked =false;
	public int ID;

	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();
	}
=======
    ColorsLevelManager Manager;
    bool selected;
    bool locked = false;
    public int ID;
    // Use this for initialization
    void Start()
    {
        Manager = FindObjectOfType<ColorsLevelManager>();
    }
>>>>>>> origin/master

    void OnTriggerEnter(Collider other)
    {
        selected = true;
    }

    void OnTriggerExit(Collider other)
    {
        selected = false;
    }

<<<<<<< HEAD
	void paint(){
		GetComponent<Renderer> ().material.color = Manager.selectedColor.color;
	}

	void Update () {
		if (selected && Input.GetKeyDown (KeyCode.Space) && !locked) {
			if (Manager.selectedColor.ID == this.ID) {
				locked = true;
				Manager.rightColors++;
			}			
			paint ();
			Manager.checkFinishLevel ();
		}
	}
}
=======
    void paint()
    {
        GetComponent<Renderer>().material.color = Manager.selectedColor.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (selected && Input.GetKeyDown(KeyCode.Space) && !locked)
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
>>>>>>> origin/master
