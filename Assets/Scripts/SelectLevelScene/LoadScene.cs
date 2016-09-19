using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {


	public void loadColorLevel(){
		SceneManager.LoadScene ("ColorsLevel");
	}

	public void loadShapesLevel(){
		SceneManager.LoadScene ("ShapesLevel");
	}

	public void loadAnimalsLevel(){
		SceneManager.LoadScene ("AnimalsLevel");
	}

	public void loadNumbersLevel(){
		SceneManager.LoadScene ("NumbersLevel");
	}

	public void loadMusicLevel(){
		SceneManager.LoadScene ("MusicLevel");
	}
}
