using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour {

    private int solution = 48;
    private int[] collectioncubes;
    public Text text;    public GameObject textUpdater;    

    // Use this for initialization
    void Start () {
        collectioncubes = new int[4];
        Array.Clear(collectioncubes, 0, 4);

    }


    // Update is called once per frame
   public  void Update () {

    }

    public void AddNumber(int value, int index)
    {
        collectioncubes[index] = value;
        checkAnswer();
    }

    public void RemoveNumber(int index)
    {
        collectioncubes[index] = 0;
    }

    private void checkAnswer()
    {
        if(collectioncubes[0] + collectioncubes[1] * collectioncubes[2] + collectioncubes[3] == solution)
        {
            text.text = "YOU WIN!!";
        }
    } 

  


}
