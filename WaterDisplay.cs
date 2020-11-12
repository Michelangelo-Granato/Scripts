using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterDisplay : MonoBehaviour
{
    private int water = 50;
    public Text waterText;
    void Update()
    {
        waterText.text = "WATER: " + water;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            water--;
        }
    }
}
