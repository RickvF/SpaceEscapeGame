using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoOpenDoor : MonoBehaviour {

    private bool openDoor = false;
    private float targetHeight = 20.0f;
    private int waitCounter = 0;

	// Use this for initialization
	void Start () {

	}

    public void OpenDoor()
    {
        openDoor = true;
    }

    // Update is called once per frame
    void Update () {
        if (openDoor)
        {
            waitCounter++;
            if (waitCounter > 5)
            {
                if (this.transform.position.y < targetHeight)
                {
                    this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, this.transform.position.z), this.transform.rotation);
                    waitCounter = 0;
                }
                else
                {
                    openDoor = false;
                }
            }
        }
	}
}
