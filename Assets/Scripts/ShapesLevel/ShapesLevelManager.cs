﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShapesLevelManager : MonoBehaviour
{

    public bool oneSelected = false;
    public TextMesh BallsLeftText, CubesLeftText, StarsLeftText, RombosLeftText;
    public int CirclesLeft = 5, HeartsLeft = 5, StarsLeft = 5, TrianglesLeft = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateText()
    {
        BallsLeftText.text = CirclesLeft.ToString();
        CubesLeftText.text = HeartsLeft.ToString();
        StarsLeftText.text = StarsLeft.ToString();
        RombosLeftText.text = TrianglesLeft.ToString();
        CheckEndLevel();
    }

    void CheckEndLevel()
    {
        if (CirclesLeft == 0 && HeartsLeft == 0 && StarsLeft == 0 && TrianglesLeft == 0)
        {
            Debug.Log("Level Complete");
            SceneManager.LoadScene("SelectionLevel");
        }
    }
}
