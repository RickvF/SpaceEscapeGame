using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class triggerPuzzle : MonoBehaviour {

    // private int correctNumber = 7;
    //private int numberOnTrigger = 0;

        public Text MessageMath;
        private string message;


    // Use this for initialization
    void Start() {
   
    }

    void getCubeNumber(int correctAnswer, Collider objectType)
    {

        int number = System.Int32.Parse(objectType.gameObject.name); //7 

        if (number == correctAnswer)
        {
            Debug.Log(number);
            message = number + " Is correct";
            setMessage();
        } else
        {
            Debug.Log(number + "  Is the Wrong number do you even math??");

            message = number + " Is the Wrong number do you even math??";
            setMessage();
        }
    }
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log(this.gameObject.name);

      
        //Do door open animation script.
        if(other.tag == "placeable")
        {
         

            if (this.gameObject.name == "TriggerSeven")
            {
                Debug.Log("Yeahh 7");
                getCubeNumber(7,other);
            }

            if (this.gameObject.name == "TriggerFive")
            {
                Debug.Log("Yeahh 5");
                getCubeNumber(5, other);
            }

            if (this.gameObject.name == "TriggerFour")
            {
                Debug.Log("Yeahh 4");
                getCubeNumber(4, other);
            }

            if (this.gameObject.name == "TriggerNine")
            {
                Debug.Log("Yeahh 9");
                getCubeNumber(9, other);
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
