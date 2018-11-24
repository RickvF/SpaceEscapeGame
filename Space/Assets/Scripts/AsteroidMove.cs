using UnityEngine;
using System.Collections;


// This shit just make the background planet spin
public class AsteroidMove : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        //this makes asteroid flyaway    
        transform.position += Vector3.forward * Time.deltaTime *10;
    }
}