using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    GameObject thebutton;

    void OnTriggerEnter(Collider obj)
    {
        thebutton = GameObject.FindWithTag("Button");
        thebutton.GetComponent<Animation>().Play("Push");
    }

    void OnTriggerExit(Collider obj)
    {
        thebutton = GameObject.FindWithTag("Button");
        thebutton.GetComponent<Animation>().Play("Release");
    }
}