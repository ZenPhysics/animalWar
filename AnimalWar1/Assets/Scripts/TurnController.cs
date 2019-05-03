using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    public enum BattleState
    {
        START,
        BUILD,
        MOVE,
        END,
        LOSE,
        WIN
    }

    private BattleState currentState;

    void Start()
    {
        currentState = BattleState.START;
    }

    void Update()
    {
        Debug.Log(currentState);

        switch (currentState)
        {
            case (BattleState.START):
                //START FUNCTIONS
                break;

            case (BattleState.BUILD):
                //BUILDING FUNCTIONS
                break;

            case (BattleState.MOVE):
                //MOVEMENT SCRIPT
                break;
            case (BattleState.END):
                //END TURN FUNCTIONS
                break;

            case (BattleState.WIN):
                //YOU WON!  TRIGGER WIN FUNCTIONS
                break;

            case (BattleState.LOSE):
                //LOSE GAME FUNCTIONS
                break;
        }
    }
    void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleState.START)
                currentState = BattleState.BUILD;
            else if (currentState == BattleState.BUILD)
                currentState = BattleState.MOVE;
            else if (currentState == BattleState.MOVE)
                currentState = BattleState.END;
            else if (currentState == BattleState.END)
                currentState = BattleState.LOSE;
            else if (currentState == BattleState.LOSE)
                currentState = BattleState.WIN;
            else if (currentState == BattleState.WIN)
                currentState = BattleState.START;
        }
    }

}
