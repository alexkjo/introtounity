using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour
{

    // Class identifiers are sentence casing
    // For more than one word UseCamelCasing
    void Shootlaser()
    {
        print("Hello World!");

        if (2 + 2 == 4)
        {
            print("It's true");
        }
        //Double equals means to compare
        //Single equal means to assign value

    }

    void ShootBlaster()
    {
        print("Ouch!");
    }
    void ShootBow()
    {
        print("Thats gotta hurt!");

        if (5 + 10 == 15)
        {
            print("That's correct!");
        }
    }

    void ShootRailGun()
    {
        print("He's probably dead.");
    }
}