using UnityEngine;
using System.Collections;

public class DiferentColorMaterial : MonoBehaviour {

    // Blue GB
    // Red R
    // Yellow RG
    // Green G
    // Use this for initialization
    void Start () {
        for (int i = 0; i < transform.childCount; i++)
        {
            Color color = transform.GetChild(i).GetComponent<Renderer>().material.color;
            if (color.r!=0)
            {
                color.r /= 2;
            }
            if (color.g != 0)
            {
                color.g /= 2;
            }
            if (color.b != 0)
            {
                color.b /= 2;
            }
            transform.GetChild(i).GetComponent<Renderer>().material.color = color;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
