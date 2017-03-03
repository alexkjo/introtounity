using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {


    public enum ColorsChoices {Red, Green, Blue };
    public ColorsChoices PlayerColor;

    public enum GameStates
    {
        LOADING,
        STARTING,
        PLAYING,
        ENDING
    }

    public GameStates currentGameState = GameStates.LOADING;

	void Start () {

        switch (PlayerColor)
        {
            case ColorsChoices.Red:
                print("This gives access to all power-ups");
                break;

            case ColorsChoices.Green:
                print("This gives access to all weapons");
                break;

            case ColorsChoices.Blue:
                print("Just Dies");
                break;

            default:
                break;
        }
	}
	

}
