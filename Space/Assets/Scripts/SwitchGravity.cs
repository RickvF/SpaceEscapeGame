using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SwitchGravity : MonoBehaviour {

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
            if (other.GetComponent<FirstPersonController>().GetGravity() == 0)
            {
                other.GetComponent<FirstPersonController>().SetGravity(2);
            }
            else if (other.GetComponent<FirstPersonController>().GetGravity() != 0)
            {
                other.GetComponent<FirstPersonController>().SetGravity(0);
            }
        }

    }
}
