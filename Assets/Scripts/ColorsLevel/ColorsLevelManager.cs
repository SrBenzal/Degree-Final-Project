using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColorsLevelManager : MonoBehaviour
{

    public Colors selectedColor;
    public GameObject[] drawParts;

    public int rightColors = 0;


    // Update is called once per frame

    public void checkFinishLevel()
    {
        if (rightColors == drawParts.Length)
        {
            Debug.Log("Level Complete");
            SceneManager.LoadScene("SelectionLevel");
        }
    }

}
