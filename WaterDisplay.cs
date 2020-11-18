using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterDisplay : MonoBehaviour
{
   
    public Text waterText;

    void Update()
    {
        waterText.text = "WATER: " + GameMaster.GM.water;
    }
}
