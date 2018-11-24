using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Raycast : MonoBehaviour {

    // Use this for initialization
    public Camera camera;
    public GameObject hand;
    private static GameObject heldObject;
    private bool itemHeld;
    private float objectDist = -0.1f;
    private float pickUpDist = 3.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (itemHeld)
            {
                heldObject.transform.parent = null;
                heldObject.GetComponent<Rigidbody>().isKinematic = false;
                heldObject = null;
                itemHeld = false;
                return;
            }
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Button")
                {
                    Debug.Log(hit.collider.gameObject.name);
                    //switch (hit.collider.gameObject.name)
                    //{
                    //    case "Button_0.5":
                    //        this.GetComponent<FirstPersonController>().SetGravity(0.5f);
                    //        break;
                    //    case "Button_1":
                    //        this.GetComponent<FirstPersonController>().SetGravity(1f);
                    //        break;
                    //    case "Button_0.25":
                    //        this.GetComponent<FirstPersonController>().SetGravity(0.25f);
                    //        break;
                    //}
                }
                else if (hit.collider.tag == "placeable")
                {
                    if (!itemHeld)
                    {
                        Debug.Log("PICKUP");
                        heldObject = hit.collider.gameObject;
                        heldObject.transform.parent = hand.transform;
                        heldObject.GetComponent<Rigidbody>().isKinematic = true;
                        var handLocation = new Vector3(0, objectDist, 0);
                        heldObject.transform.localPosition = handLocation;
                        itemHeld = true;
                    }
                }


                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }
}
