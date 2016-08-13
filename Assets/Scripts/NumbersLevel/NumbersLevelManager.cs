using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumbersLevelManager : MonoBehaviour {

    int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public GameObject[] numbersPanels;
    public Text RightNumber;

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

    // Use this for initialization
    void Start () {
        string s = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            s += numbers[i].ToString();
            s += " ";
        }
        Debug.Log(s);

        Shuffle(numbers);
        s="";
        for (int i = 0; i < numbers.Length; i++)
        {
            s += numbers[i].ToString();
            s += " ";
        }
        Debug.Log(s);
        ReWritePanels();
        setRightNumber();
    }

    void ReWritePanels() {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbersPanels[i].GetComponentInChildren<TextMesh>().text = numbers[i].ToString();
        }
    }

    public void setRightNumber() {
        RightNumber.text = Random.Range(0, 10).ToString();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
