﻿using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

    public bool myBool;
    public string myString = "Dog";
    public int num1;
    public int num2;

	// Use this for initialization
	void Start () {
	    if (myBool)
        {
            print(true);
        }

        if(myString == "Cat")
        {
            print("Cat");
        }

        if(!myBool)
        {
            print("False");
        }

        if(myString != "Cat")
        {
            print(myString);
        }

        if(num1 + num2 == 7 )
        {
            print(7);
        }

        if(num1 + num2 != 7)
        {
            print(num1 + num2);
        }
	}

}
