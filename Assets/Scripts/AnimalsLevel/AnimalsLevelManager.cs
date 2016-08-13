using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimalsLevelManager : MonoBehaviour
{
    string[] animals = {"Dog", "Cat","Cow", "Sheep", "Pig", "Rooster", "Duck", "Elephant" };

    public Text RightAnimalText;
    string RightAnimal = "";
    public string animalSelected;


    // Use this for initialization
    void Start()
    {
        setRightAnimal();
    }

    public void checkSelected()
    {
        if (animalSelected == RightAnimal)
        {
            Debug.Log("Bien");
            setRightAnimal();
        }
        else
        {
            Debug.Log("Mal");
        }
    }


    public void setRightAnimal()
    {
        if (RightAnimal != "")
        {
            bool diferente = false;
            while (!diferente)
            {
                string newAnimal = animals[Random.Range(0, animals.Length)];
                if (newAnimal != RightAnimal)
                {
                    RightAnimal = newAnimal;
                    diferente = true;
                }
            }
        }
        else
        {
            RightAnimal = animals[Random.Range(0, animals.Length)];
        }
        RightAnimalText.text = RightAnimal;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
