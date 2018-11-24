using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoor : MonoBehaviour
{

    public float doorHeight;

    public GameObject trigger;

    private float defaultHeight = -1.24f;
    private float maxHeight = 3.82f;

    private int waitCounter = 50;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        doorHeight = trigger.GetComponent<trigger>().percentageWeight / 10;
        waitCounter++;
        if (this.transform.position.y != (defaultHeight + doorHeight) && waitCounter > 5)
        {
            if (this.transform.position.y < (defaultHeight + doorHeight))
            {
                this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, this.transform.position.z), this.transform.rotation);
            }
            else if (this.transform.position.y > (defaultHeight + doorHeight))
            {
                this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y - 0.1f, this.transform.position.z), this.transform.rotation);
            }
            waitCounter = 0;
        }
    }
}
