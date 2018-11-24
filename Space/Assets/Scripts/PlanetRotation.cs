using UnityEngine;
using System.Collections;


// This shit just make the background planet spin
public class PlanetRotation : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}