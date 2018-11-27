using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoor : MonoBehaviour
{

    public float doorHeight;

    public GameObject trigger;

    private float defaultHeight = 0.0f;
    private float maxHeight = 4.5f;

    private int waitCounter = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        doorHeight = trigger.GetComponent<trigger>().percentageWeight / 10;
        doorHeight = ((maxHeight - defaultHeight) / 10) * doorHeight;
        //Debug.Log("Door: "  + doorHeight + " real: " + this.transform.position.y);
        
        waitCounter++;
        if (this.transform.position.y != (defaultHeight + doorHeight) && waitCounter > 2)
        {
            //Debug.Log("Both: "  + (defaultHeight + doorHeight));
            if (this.transform.position.y < ((defaultHeight + doorHeight) - 0.5f))
            {
                this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, this.transform.position.z), this.transform.rotation);
            }
            else if (this.transform.position.y > ((defaultHeight + doorHeight) + 0.5f))
            {
                this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y - 0.1f, this.transform.position.z), this.transform.rotation);
            }
            waitCounter = 0;
        }
    }
}
