using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class triggerPuzzle : MonoBehaviour {
    
    public Cube cubes;


    // Use this for initialization
    void Start() {

    }

    void getCubeNumber(int correctAnswer,int secondCorrectAnswer, Collider objectType, int index)
    {
        
        int number;
        if (int.TryParse(objectType.gameObject.name, out number))
        {

            if (number == correctAnswer || number == secondCorrectAnswer)
            {
                cubes.AddNumber(number, index);
            }
        }
    }

    void removeCubeNumber(int correctAnswer, int secondCorrectAnswer, Collider objectType, int index)
    {

        int number;
        if (int.TryParse(objectType.gameObject.name, out number))
        {

            if (number == correctAnswer || number == secondCorrectAnswer)
            {
                cubes.RemoveNumber(index);
            }
        }
    }

    // Update is called once per frame
    void Update () {
    }
        

    void OnTriggerEnter(Collider other)
    {

        // Debug.Log(this.gameObject.name);

      
        //Do door open animation script.
        if(other.tag == "placeable")
        {        

            if (this.gameObject.name == "TriggerSeven")
            {
            
                getCubeNumber(7,5,other, 0);

            }

            if (this.gameObject.name == "TriggerFive")
            {
          
                getCubeNumber(5,7, other, 3);
            }

            if (this.gameObject.name == "TriggerFour")
            {
  
                getCubeNumber(4,9, other, 1);
            }

            if (this.gameObject.name == "TriggerNine")
            {

                getCubeNumber(9,4, other, 2);
            }

        }
    }
    


    void OnTriggerExit(Collider other)
    {
        //Do door close animation script.
        if (other.tag == "placeable")
        {
            if (this.gameObject.name == "TriggerSeven")
            {

                removeCubeNumber(7, 5, other, 0);

            }

            if (this.gameObject.name == "TriggerFive")
            {

                removeCubeNumber(5, 7, other, 3);
            }

            if (this.gameObject.name == "TriggerFour")
            {

                removeCubeNumber(4, 9, other, 1);
            }

            if (this.gameObject.name == "TriggerNine")
            {

                removeCubeNumber(9, 4, other, 2);
            }
            // Debug.Log(numberOnTrigger);
        }
    }
}
