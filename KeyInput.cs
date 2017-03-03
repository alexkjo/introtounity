using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Input is a class, GetKey is a function, and Keycode is an arguement.
	void Update () {
	    if(Input.GetKey(KeyCode.A))
        {
            print("I hit A.");
        }
	}
}
