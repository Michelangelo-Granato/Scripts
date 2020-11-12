using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DayDisplay : MonoBehaviour
{
    private int day = 1;
    public Text dayText;
    void Update()
    {
        dayText.text = "DAY: " + day;

    }


}
