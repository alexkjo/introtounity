using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour {

    public string string1;
    public string string2;


    // Use this for initialization
    public void OnButtonClick()
    {
        if (string1 == "Thing1" && string2 == "Thing2")
        {
            print("These things are quite tame.");
        }

        if (string1 == "Thing1" || string2 == "Thing2")
        {
            print("It's fun to have fun if you know what to do.");
        }

        if (string1 != "Thing1" && string2 != "Thing2")
        {
            print("Oh what a shame, what a shame, what a shame.");
        }

    }
}
