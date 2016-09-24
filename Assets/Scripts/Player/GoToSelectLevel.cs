using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToSelectLevel : MonoBehaviour {

	void OnTriggerStay(Collider other) {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene ("SelectionLevel");
		}
	}
}
