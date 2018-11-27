using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoOpenDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void open()
    {
        this.GetComponent<MeshCollider>().enabled = false;
        this.GetComponent<BoxCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
    }
}
