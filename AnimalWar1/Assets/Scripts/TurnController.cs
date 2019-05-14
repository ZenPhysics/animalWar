using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    public enum BattleState
    {
        START,
        LOOK,
        BUILD,
        MOVE,
        COMBAT,
        END,
        LOSE,
        WIN
    }

    public GameObject menuObject;
    public GameObject animalMovement;
    public GameObject ResourceObject;
    public bool notDone = true;

    public GameObject CanvasTame;
    public GameObject CanvasWild;
   

    public bool isWildTurn;

    private BattleState currentState;

    void Start()
    {
        currentState = BattleState.START;
        TurnMachine();
        isWildTurn = false;
        //isWildTurn = false;
    }

    public void TurnMachine()
    {
        Debug.Log(currentState);

        switch (currentState)
        {

            case (BattleState.START):
                //START FUNCTIONS
                //animalMovement.GetComponent<animalController>().ResetMovement();
                AnimalList.ResetAnimals();
                Debug.Log("////////////////reset animals should be called");

                break;

            case (BattleState.LOOK):
                //Look function
                if (!isWildTurn)
                {
                    ResourceObject.GetComponent<Resources>().AddMoneyTame();
                }
                else
                {
                    ResourceObject.GetComponent<Resources>().AddMoneyWild();
                }
             
                break;

            case (BattleState.BUILD):
                //BUILDING FUNCTIONS
                if (isWildTurn)
                {
                    menuObject.GetComponent<MenuManger>().CallWildMenu();
                }
                else
                {
                    menuObject.GetComponent<MenuManger>().CallTameMenu();
                }
                break;

            case (BattleState.MOVE):
                menuObject.GetComponent<MenuManger>().TurnOffMenu();
                break;

            case (BattleState.COMBAT):
                //Combat mechanics
                break;

            case (BattleState.END):
                if (isWildTurn)
                {
                    isWildTurn = false;
                }
                else
                {
                    isWildTurn = true;
                }
                break;

            case (BattleState.WIN):
                //YOU WON!  TRIGGER WIN FUNCTIONS
                break;

            case (BattleState.LOSE):
                //LOSE GAME FUNCTIONS
                break;
        }
    }

    void Update()
    {
       
    }
    public void ChangeState()
    {
        if (currentState == BattleState.START)
        {
            currentState = BattleState.LOOK;
            TurnMachine();
        }
        else if (currentState == BattleState.LOOK)
        {
            currentState = BattleState.BUILD;
            TurnMachine();
        }
        else if (currentState == BattleState.BUILD)
        {
            currentState = BattleState.MOVE;
            TurnMachine();
        }

        else if (currentState == BattleState.MOVE)
        {
            currentState = BattleState.COMBAT;
            TurnMachine();
        }

        else if (currentState == BattleState.COMBAT)
        {
            currentState = BattleState.END;
            TurnMachine();
        }
        else if (currentState == BattleState.END)
        {
            //currentState = BattleState.LOSE;
            //TurnMachine();
            currentState = BattleState.START;
            TurnMachine();
        }
        //else if (currentState == BattleState.LOSE)
        //{
        //    currentState = BattleState.WIN;
        //    TurnMachine();
        //}

        //else if (currentState == BattleState.WIN)
        //{
        //    currentState = BattleState.START;
        //    TurnMachine();
        //}        
    }

}
