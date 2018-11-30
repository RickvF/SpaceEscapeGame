using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textUpdater : MonoBehaviour {

    //text fields for buttons
    public Text b1;
    public Text b2;
    public Text b3;
    public Text b4;

	public void updateText(int value, int button)
    {
        string textVal = "";
        if (value != 0)
        {
            textVal = value.ToString();
        } 
        switch (button)
        {
            case 0:
                b1.text = textVal;
                break;
            case 1:
                b2.text = textVal;
                break;
            case 2:
                b3.text = textVal;
                break;
            case 3:
                b4.text = textVal;
                break;
            default:
                break;
        }
    }
}
