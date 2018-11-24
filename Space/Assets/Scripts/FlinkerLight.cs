using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlinkerLight : MonoBehaviour
{

    public Light celLight;
    public GameObject celDoor;

    private int duration = 100;
    private float waitTime = 0.3f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Flashing());

    }

    IEnumerator Flashing()
    {
        int i = 0;
        for (i = 0; i < duration; i++)
        {
            if (i % 5 == 0)
            {
                waitTime -= 0.05f;
            }
            yield return new WaitForSeconds(waitTime);
            celLight.enabled = !celLight.enabled;
        }

        celLight.enabled = false;
        celDoor.GetComponent<autoOpenDoor>().open();
    }
}
