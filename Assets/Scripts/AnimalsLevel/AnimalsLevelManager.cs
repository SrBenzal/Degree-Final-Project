using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimalsLevelManager : MonoBehaviour
{
	const int MaxRightNumbers = 5;
<<<<<<< HEAD
	int Rights;
	string[] animals = {"Cat","Cow", "Dog", "Duck", "Elephant", "Pig", "Rooster", "Sheep"};

=======
	int Rights=0;
	string[] animals = {"Dog", "Cat","Cow", "Sheep", "Pig", "Rooster", "Duck", "Elephant" };
    public GameObject[] animalsList;
>>>>>>> origin/master
    public Text RightAnimalText;
    string RightAnimal = "";
    public string animalSelected;
    int index = 0;

<<<<<<< HEAD
	public GameObject animalsParent;

=======
    public Animator anim;
    // Use this for initialization
>>>>>>> origin/master
    void Start()
    {
        Shuffle(animals);
        setRightAnimal(index);
    }

    public void checkSelected()
    {
        if (animalSelected == RightAnimal)
        {
            Debug.Log("Bien");
<<<<<<< HEAD
			CheckFinishLevel ();
=======
            index++;
            CheckFinishLevel();
            if (index<animals.Length)
            {
                setRightAnimal(index);
            }
>>>>>>> origin/master
        }
        else
            Debug.Log("Mal");
    }

	void CheckFinishLevel(){
		Rights++;
		if (index==animals.Length) {
			Debug.Log ("Level Complete");
<<<<<<< HEAD
			SceneManager.LoadScene ("SelectionLevel");
		} else {
			setRightAnimal();
		}
	}

    public void setRightAnimal()
    {
		int rndIndex = Random.Range (0, animals.Length);;
        if (RightAnimal != "")
=======
            anim.enabled = true;
		}
	}

    void GoToSelectLevel() {
        SceneManager.LoadScene("SelectionLevel");
    }
    public static void Shuffle(string[] vector) //shuffle int vector randomly 
    {
        int n = vector.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            string value = vector[k];
            vector[k] = vector[n];
            vector[n] = value;
        }
    }


    public void setRightAnimal(int i)
    {
        /*if (RightAnimal != "")
>>>>>>> origin/master
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
<<<<<<< HEAD
			RightAnimal = animals[rndIndex];
		animalsParent.transform.GetChild (rndIndex).GetComponent<AudioSource> ().Play ();
=======
        {
            RightAnimal = animals[Random.Range(0, animals.Length)];
        }
        RightAnimalText.text = RightAnimal;*/

        RightAnimal = animals[i];
        StopAnimalSound();
        SelectAnimalSound(animals[i]);
>>>>>>> origin/master
        RightAnimalText.text = RightAnimal;
    }

    void StopAnimalSound()
    {
        foreach (var animal in animalsList)
        {
            animal.GetComponent<AudioSource>().Stop();
        }
    }
    void SelectAnimalSound(string animal) {
        switch (animal)
        {
            case "Cat":
                animalsList[0].GetComponent<AudioSource>().Play();
                break;

            case "Cow":
                animalsList[1].GetComponent<AudioSource>().Play();
                break;

            case "Dog":
                animalsList[2].GetComponent<AudioSource>().Play();
                break;

            case "Duck":
                animalsList[3].GetComponent<AudioSource>().Play();
                break;

            case "Elephant":
                animalsList[4].GetComponent<AudioSource>().Play();
                break;

            case "Pig":
                animalsList[5].GetComponent<AudioSource>().Play();
                break;

            case "Rooster":
                animalsList[6].GetComponent<AudioSource>().Play();
                break;

            case "Sheep":
                animalsList[7].GetComponent<AudioSource>().Play();
                break;

            default:
                Debug.Log("Animal " + animal + " not found");
                break;
        }
    }
}
