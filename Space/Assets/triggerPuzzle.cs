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

    void getCubeNumber(Collider objectType)
    {

        int number = System.Int32.Parse(objectType.gameObject.name); //7 

        if (number == 7)
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
        //Do door open animation script.
        if(other.tag == "placeable")
        {
            getCubeNumber(other);


            
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
