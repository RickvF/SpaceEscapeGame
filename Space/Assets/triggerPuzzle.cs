using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class triggerPuzzle : MonoBehaviour {

    // private int correctNumber = 7;
    //private int numberOnTrigger = 0;

        public Text MessageMath;
        private string message;
    // private  List<int> collectionCubes = new List<int>();
    public Cube cubes;


    // Use this for initialization
    void Start() {
        cubes = new Cube();

    }

    void getCubeNumber(int correctAnswer,int secondCorrectAnswer, Collider objectType)
    {

        int number = System.Int32.Parse(objectType.gameObject.name);

    
        if (number == correctAnswer || number == secondCorrectAnswer)
        {
            Debug.Log(number);
            message = number + " is correct";
            setMessage();
            cubes.Update();
        } else
        {

            message = number + " is the Wrong number do you even math??";
            setMessage();
          
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
            
                getCubeNumber(7,5,other);

            }

            if (this.gameObject.name == "TriggerFive")
            {
          
                getCubeNumber(5,7, other);
            }

            if (this.gameObject.name == "TriggerFour")
            {
  
                getCubeNumber(4,9, other);
            }

            if (this.gameObject.name == "TriggerNine")
            {

                getCubeNumber(9,4, other);
            }

        }
    }

    void setMessage()
    {
        MessageMath.text = message.ToString();

    }


    void OnTriggerExit(Collider other)
    {
        //Do door close animation script.
        if (other.tag == "placeable")
        {
         
          // Debug.Log(numberOnTrigger);
        }
    }
}
