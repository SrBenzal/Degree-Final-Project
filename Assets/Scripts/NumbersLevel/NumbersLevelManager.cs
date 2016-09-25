using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumbersLevelManager : MonoBehaviour
{

    int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public GameObject[] numbersPanels;
    public Text RightNumberText;
    int RightNumber = -1;
    public int numberSelected;

    public GameObject numbersParent;

    public BodySourceView player;

    public static void Shuffle(int[] vector) //shuffle int vector randomly 
    {
        int n = vector.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int value = vector[k];
            vector[k] = vector[n];
            vector[n] = value;
        }
    }

    void Start()
    {
        string s = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            s += numbers[i].ToString();
            s += " ";
        }
        Debug.Log(s);

        Shuffle(numbers);
        s = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            s += numbers[i].ToString();
            s += " ";
        }
        Debug.Log(s);
        ReWritePanels();
        setRightNumber();
    }

    public void checkSelected()
    {
        if (numberSelected == RightNumber)
        {
            Debug.Log("Bien");
            setRightNumber();
        }
        else
            Debug.Log("Mal");
    }

    void ReWritePanels()
    {
        for (int i = 0; i < numbers.Length; i++)
            numbersPanels[i].GetComponentInChildren<TextMesh>().text = numbers[i].ToString();
    }

    public void setRightNumber()
    {
        int rndIndex = Random.Range(0, numbers.Length);
        if (RightNumber != -1)
        {
            bool diferente = false;
            while (!diferente)
            {
                rndIndex = Random.Range(0, numbers.Length);
                if (rndIndex != RightNumber)
                {
                    RightNumber = rndIndex;
                    diferente = true;
                }
            }
        }
        else
            RightNumber = rndIndex;
        numbersPanels[rndIndex].GetComponent<AudioSource>().Play();
        Debug.Log(rndIndex);
        Debug.Log(numbersPanels[rndIndex]);
        RightNumberText.text = RightNumber.ToString();
    }
}