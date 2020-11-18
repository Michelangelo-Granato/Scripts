using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OilDisplay : MonoBehaviour
{
    public Text fuelText;
  
    void Update()
    {
        fuelText.text = "FUEL: " + GameMaster.GM.fuel;   
    }
}
