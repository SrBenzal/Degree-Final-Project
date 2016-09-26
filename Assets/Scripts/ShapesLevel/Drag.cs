using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour
{
    public GameObject grid;
    public string type;

    ShapesLevelManager Manager;
    Player Player;
    float speed = 1.5f;
    bool selected = false, arrastrando = false, inPosition = false, music = false;
    Vector3 MarginVector = new Vector3(0.5f,0f,0.5f);

	void Start()
    {
        Manager = FindObjectOfType<ShapesLevelManager>();
        Player = FindObjectOfType<Player>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other == grid.GetComponent<Collider>())
        {
            inPosition = true;
            switch (type)
            {
                default:
                    break;
                case "circle":
                    Manager.CirclesLeft--;
                    break;
                case "heart":
                    Manager.HeartsLeft--;
                    break;
                case "star":
                    Manager.StarsLeft--;
                    break;
                case "triangle":
                    Manager.TrianglesLeft--;
                    break; 
            }
            Manager.updateText();
        }
        else
        {
            if (!Manager.oneSelected)
                selected = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (!arrastrando)
            selected = false;
    }

    void drag()
    {
        Vector3 finalPosition = Player.transform.position - MarginVector;
        transform.position = Vector3.Lerp(transform.position, finalPosition, Time.deltaTime * 3 * speed);
    }

    void OnTriggerStay(Collider other) {
        if (!music)
        {
            if (Manager.player.RightHandUp())
            {
                GetComponent<AudioSource>().Play();
                music = true;
            }

            if (Manager.player.ClapHands())
            {
                selected = true;
                arrastrando = true;
            }

			if (Input.GetKeyDown(KeyCode.Space))
        	{
                selected = true;
                arrastrando = true;
        	}
			if (Input.GetKeyDown(KeyCode.H))
			{
				GetComponent<AudioSource>().Play();
				music = true;
			}
        }
        else
        {
            if (!GetComponent<AudioSource>().isPlaying)
            {
                music = false;
            }
        }
    }

    void getArrastrando() {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (arrastrando)
            {
                arrastrando = false;
                selected = false;
                Manager.oneSelected = false;
            }
            else
            {
                if (selected)
                    arrastrando = true;
            }
        }*/
        if (!music)
        {
            if (Manager.player.RightHandUp())
            {
                GetComponent<AudioSource>().Play();
                music = true;
            }

            if (Manager.player.ClapHands())
            {
                if (arrastrando)
                {
                    arrastrando = false;
                    selected = false;
                    Manager.oneSelected = false;
                }
                else
                {
                    if (selected)
                        arrastrando = true;
                }
            }
        }
        else
        {
            if (!GetComponent<AudioSource>().isPlaying)
            {
                music = false;
            }
        }
    }
		
    void Update()
    {
        //getArrastrando();
        if (selected && arrastrando && !inPosition)
            drag();
    }
}
