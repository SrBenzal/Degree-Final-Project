using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit ();
		}
	}
}
