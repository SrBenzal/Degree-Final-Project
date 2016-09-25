using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneAnimals : MonoBehaviour {

    public BodySourceView player;

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }

    void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = new Color(0.75f, 0.75f, 0.75f, 1);
    }
    void OnTriggerStay(Collider other)
    {
        if (player.RightHandUp())
        {
            loadShapesLevel();
        }
    }
    public void loadShapesLevel()
    {
        SceneManager.LoadScene("AnimalsLevel");
    }
}
