using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClose: MonoBehaviour
{
    public BodySourceView player;

    void OnTriggerStay(Collider other)
    {
        if (player.ClapHands())
        {
            SceneManager.LoadScene("SelectionLevel");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SelectionLevel");
        }
    }
}