using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SwitchGravity : MonoBehaviour {

    public bool disableGravity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            Debug.Log(other.name);
            Vector3 dir = other.transform.position - transform.position;
            Debug.Log("Direction: " + dir);
            if(dir.z > 0)
            {
                if (disableGravity)
                {
                    Debug.Log("Turn off");
                    other.GetComponent<FirstPersonController>().SetGravity(0);
                }
                else
                {
                    Debug.Log("Turn on");
                    other.GetComponent<FirstPersonController>().SetGravity(2);
                }
                
            } else
            {
                if (disableGravity)
                {
                    Debug.Log("Turn on");
                    other.GetComponent<FirstPersonController>().SetGravity(2);
                }
                else
                {
                    Debug.Log("Turn off");
                    other.GetComponent<FirstPersonController>().SetGravity(0);
                }
            }
        }

    }
}
