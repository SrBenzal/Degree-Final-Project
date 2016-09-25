using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneNumbers : MonoBehaviour {

    public BodySourceView player;

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }

    void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1);
    }
    void OnTriggerStay(Collider other)
    {
        if (player.ClapHands())
        {
            loadShapesLevel();
        }
    }
    public void loadShapesLevel()
    {
        SceneManager.LoadScene("NumbersLevel");
    }
}
