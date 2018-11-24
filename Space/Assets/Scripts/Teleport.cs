using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform target = null; //Teleport 1
    public Transform target2 = null; //Teleport 2
    bool bJump = false; //is teleport 1 active ?
    bool bJump2 = false; //is teleport 2 active ?

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleport" && bJump == false && bJump2 == false) //jump from from teleport 1 to teleport 2
        {
            this.transform.position = target.position;
            bJump = true;
        }

        if (other.gameObject.tag == "Teleport2" && bJump == false && bJump2 == false) //jump from from teleport 2 to teleport 1
        {
            this.transform.position = target2.position;
            bJump2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Teleport")
        {
            bJump2 = false; // Deactivate teleport 2
        }
        if (other.gameObject.tag == "Teleport2")
        {
            bJump = false; // Deactivate teleport 2
        }
    }

    void Update()
    {

    }
}
