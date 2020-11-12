using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OilDisplay : MonoBehaviour
{
    int fuel = 0;
    public Text FuelText;

    void Update()
    {
        FuelText.text = "FUEL: " + fuel;


    }


}
