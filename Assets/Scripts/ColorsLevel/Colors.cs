using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour
{

<<<<<<< HEAD
	ColorsLevelManager Manager;
	public int ID;
	public Color color;

	void Start () {
		Manager = FindObjectOfType<ColorsLevelManager> ();
	}

	void OnTriggerStay(Collider other) {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			color = GetComponent<Renderer> ().material.color;
			Manager.selectedColor = this;
			Debug.Log (Manager.selectedColor);
		}
		if (Input.GetKeyDown(KeyCode.H)) {
			GetComponent<AudioSource> ().Play ();
		}
	}
=======
    ColorsLevelManager Manager;
    public int ID;
    public Color color;

    // Use this for initialization
    void Start()
    {
        Manager = FindObjectOfType<ColorsLevelManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        color = GetComponent<Renderer>().material.color;
        Manager.selectedColor = this;
        Debug.Log(Manager.selectedColor);
    }
>>>>>>> origin/master
}
