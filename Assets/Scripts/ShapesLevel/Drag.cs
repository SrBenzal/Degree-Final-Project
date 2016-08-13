using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour
{
    public GameObject grid;
    public string type;

    ShapesLevelManager Manager;
    Player Player;
    float speed = 1.5f;
    bool selected=false, arrastrando=false, inPosition=false;
    Vector3 MarginVector = new Vector3(0.5f,0f,0.5f);
    // Use this for initialization
    void Start()
    {
        Manager = FindObjectOfType<ShapesLevelManager>();
        Player = FindObjectOfType<Player>();
    }

    void IsInPosition() {
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
                case "ball":
                    Manager.BallsLeft--;
                    break;
                case "cube":
                    Manager.CubesLeft--;
                    break;
                case "star":
                    Manager.StarsLeft--;
                    break;
                case "rombo":
                    Manager.RombosLeft--;
                    break; 
            }
            Manager.updateText();
        }
        else
        {
            if (!Manager.oneSelected)
            {
                selected = true;
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (!arrastrando)
        {
            selected = false;
        }
    }

    void drag()
    {

        Vector3 finalPosition = Player.transform.position - MarginVector;
        transform.position = Vector3.Lerp(transform.position, finalPosition, Time.deltaTime * 3 * speed);
    }

    void getArrastrando() {
        if (Input.GetKeyDown(KeyCode.Space))
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
                {
                    arrastrando = true;
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        getArrastrando();
        //Debug.Log("Object: " + this.name + " selected: " + selected);
        if (selected && arrastrando && !inPosition)
        {
            drag();
        }
    }
}
