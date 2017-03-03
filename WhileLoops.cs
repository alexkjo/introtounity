using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour {

    int i = 0;
    public string[] colors;
    
    // While loops are for accessing a lot of code.
	void Start () {
        while (i < 10)
        {
            print(colors [i]);
            i++;
        }

        print("Done.");

    // This will go through the whole array instead of just till 9.
        while (i < colors.Length)
        {
            print(colors[i]);
            i++;
        }

        print("Done.");

	}
	
}
