using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    // Use this for initialization
    public bool enter = true;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
            other.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
