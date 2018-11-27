using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour {

    private float minWeight = 75.0f;
    private float weightOnTrigger = 0.0f;

    public float percentageWeight = 0.0f;

    public Text weightText;

    // Use this for initialization
    void Start()
    {
        ChangeText(0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        //Do door open animation script.
        if (other.tag == "placeable")
        {
            weightOnTrigger += other.gameObject.GetComponent<Rigidbody>().mass;
            ChangeText(weightOnTrigger);
            Debug.Log(weightOnTrigger);
            percentageWeight = (weightOnTrigger / minWeight) * 100;
            Debug.Log(percentageWeight);
            
        }
    }


    void OnTriggerExit(Collider other)
    {
        //Do door close animation script.
        if (other.tag == "placeable")
        {
            weightOnTrigger -= other.gameObject.GetComponent<Rigidbody>().mass;
            Debug.Log(weightOnTrigger);
            ChangeText(weightOnTrigger);
            percentageWeight = (weightOnTrigger / minWeight) * 100;
            Debug.Log(percentageWeight);
        }
    }

    void ChangeText(float weight)
    {
        weightText.text = "Stand on button \nto open the door \n \nCurrent Weight:\n       " + weight + " kg";
    }

}
