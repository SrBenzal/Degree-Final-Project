using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClose : MonoBehaviour {

    bool selected;

    // Use this for initialization
    void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        selected = true;
    }

    void OnTriggerExit(Collider other)
    {
        selected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (selected && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SelectionLevel");
        }
    }
}
