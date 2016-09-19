using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimalsLevelManager : MonoBehaviour
{
	const int MaxRightNumbers = 5;
	int Rights;
	string[] animals = {"Dog", "Cat","Cow", "Sheep", "Pig", "Rooster", "Duck", "Elephant" };

    public Text RightAnimalText;
    string RightAnimal = "";
    public string animalSelected;

    void Start()
    {
        setRightAnimal();
    }

    public void checkSelected()
    {
        if (animalSelected == RightAnimal)
        {
            Debug.Log("Bien");
			CheckFinishLevel ();
            setRightAnimal();
        }
        else
            Debug.Log("Mal");
    }

	void CheckFinishLevel(){
		Rights++;
		if (Rights==MaxRightNumbers) {
			Debug.Log ("Level Complete");
			SceneManager.LoadScene ("SelectionLevel");
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
}
