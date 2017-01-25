using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
            print("Change Color to red.");
        }
        if (Input.GetKeyDown(KeyCode.G)){
            GetComponent<Renderer>().material.color = Color.green;
            print("Change color to green.");
        }
            if (Input.GetKeyDown(KeyCode.B)) {
                GetComponent<Renderer>().material.color = Color.blue;
                print("Change color to blue.");
            }
            if (Input.GetKeyDown(KeyCode.Delete)) {
                GetComponent<Renderer>().material.color = Color.white;
                print("Change color to White.");
            }
            if (Input.GetKeyDown(KeyCode.Space)){
                GetComponent<Renderer>().material.color = Color.black;
                print("Change color to black.");
            }
            if (Input.GetKeyDown(KeyCode.KeypadEnter)){
                GetComponent<Renderer>().material.color = Color.yellow;
                print("Change color to Yellow.");
            }
    }
}