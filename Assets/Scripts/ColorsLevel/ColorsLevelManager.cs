using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColorsLevelManager : MonoBehaviour
{

    // Use this for initialization
    public Colors selectedColor;
    public GameObject[] drawParts;

    public int rightColors = 0;
    void Start()
    {
    }

    // Update is called once per frame

    public void checkFinishLevel()
    {
        if (rightColors == drawParts.Length)
        {
            Debug.Log("Level Complete");
            SceneManager.LoadScene("SelectionLevel");
        }
    }

    /*public void selectColor(GameObject g){
		Debug.Log ("d2");

		selectedColor = g.GetComponent<Renderer> ().material.color;
		Debug.Log (selectedColor);
	}*/
}
