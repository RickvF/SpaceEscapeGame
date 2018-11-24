using UnityEngine;
using System.Collections;


// This shit just make the background planet spin
public class SpaceCraftMove : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * 30);

        // Move the object upward in world space 1 unit/second.
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}

