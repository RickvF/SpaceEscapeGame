using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

    private float minWeight = 75.0f;
    private float weightOnTrigger = 0.0f;

    public float percentageWeight = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider other)
    {
        //Do door open animation script.
        if(other.tag == "placeable")
        {
            weightOnTrigger += other.gameObject.GetComponent<Rigidbody>().mass;
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
            percentageWeight = (weightOnTrigger / minWeight) * 100;
            Debug.Log(percentageWeight);
        }
    }
}
