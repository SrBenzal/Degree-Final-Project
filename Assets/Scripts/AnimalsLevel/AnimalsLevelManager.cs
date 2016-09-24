using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimalsLevelManager : MonoBehaviour
{
	const int MaxRightNumbers = 5;
	int Rights;
	string[] animals = {"Cat","Cow", "Dog", "Duck", "Elephant", "Pig", "Rooster", "Sheep"};

    public Text RightAnimalText;
    string RightAnimal = "";
    public string animalSelected;

	public GameObject animalsParent;

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
        }
        else
            Debug.Log("Mal");
    }

	void CheckFinishLevel(){
		Rights++;
		if (Rights==MaxRightNumbers) {
			Debug.Log ("Level Complete");
			SceneManager.LoadScene ("SelectionLevel");
		} else {
			setRightAnimal();
		}
	}

    public void setRightAnimal()
    {
		int rndIndex = Random.Range (0, animals.Length);;
        if (RightAnimal != "")
        {
            bool diferente = false;
            while (!diferente)
            {
				rndIndex = Random.Range (0, animals.Length);
                string newAnimal = animals[rndIndex];
                if (newAnimal != RightAnimal)
                {
                    RightAnimal = newAnimal;
                    diferente = true;
                }
            }
        }
        else
			RightAnimal = animals[rndIndex];
		animalsParent.transform.GetChild (rndIndex).GetComponent<AudioSource> ().Play ();
        RightAnimalText.text = RightAnimal;
    }
}
