﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimalsLevelManager : MonoBehaviour
{
	const int MaxRightNumbers = 5;
	int Rights=0;
	string[] animals = {"Dog", "Cat","Cow", "Sheep", "Pig", "Rooster", "Duck", "Elephant" };
    public GameObject[] animalsList;
    public Text RightAnimalText;
    string RightAnimal = "";
    public string animalSelected;
    int index = 0;

    public Animator anim;
    // Use this for initialization
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
            index++;
            CheckFinishLevel();
            if (index<animals.Length)
            {
                setRightAnimal(index);
            }
        }
        else
        {
            Debug.Log("Mal");
        }
    }

	void CheckFinishLevel(){
		Rights++;
		if (index==animals.Length) {
			Debug.Log ("Level Complete");
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
        RightAnimalText.text = RightAnimal;*/

        RightAnimal = animals[i];
        StopAnimalSound();
        SelectAnimalSound(animals[i]);
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
