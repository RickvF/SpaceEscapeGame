using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    private List<int> collectionCubes = new List<int>();

    public List<int> CollectionCubes
    {
        get
        {
            return collectionCubes;
        }

        set
        {
            collectionCubes = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}


    // Update is called once per frame
   public  void Update () {
        collectionCubes.Add(4);
        Debug.Log(collectionCubes.Count);
    }

  


}
