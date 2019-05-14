using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalController : MonoBehaviour
{
    public int AnimalRow;
    public int AnimalColumn;

    public bool IsEnemy;
    public float MovementPoints;
    public float Health;
    public float Attack;
    public float Armor;
    public float size;
    public int intimidation;
    public int Anthem;
    public int ResourceCost;
    public bool CanWalk;
    public bool CanFly;
    public bool CanSwim;
    public bool IsSelected = false;
    public float TotalPointsPerTurn;

    private MPGenertaor mpGenertaor;

    public bool hasAttacked;

    


    // Start is called before the first frame update
    void Start()
        
       // TotalPointsPerTurn += MovementPoints; 
    {
        TotalPointsPerTurn = MovementPoints;
        // Getting Reference To Map Generator in Able to Use Helper Functions
        var mapObj = GameObject.Find("MapManager");
        mpGenertaor = mapObj.GetComponent<MPGenertaor>();
        hasAttacked = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    public void MoveCharacter()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && IsSelected == true)
        {
            MapTile tileObj = mpGenertaor.GetTileAt((AnimalColumn + 1), AnimalRow);
            if (tileObj.CanWalkOver == CanWalk || tileObj.CanSwimThrough == CanSwim || tileObj.CanFlyOver == CanFly)
            {
                if (MovementPoints - tileObj.MovementCost >= 0)
                {
                    MovementPoints -= tileObj.MovementCost;
                    transform.position = tileObj.GetConnectPoint().position;
                    AnimalColumn += 1;
                }
            }                            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && IsSelected == true)
        {
            MapTile tileObj = mpGenertaor.GetTileAt((AnimalColumn - 1), AnimalRow);
            if (tileObj.CanWalkOver == CanWalk || tileObj.CanSwimThrough == CanSwim || tileObj.CanFlyOver == CanFly)
            {
                if (MovementPoints - tileObj.MovementCost >= 0)
                {
                    MovementPoints -= tileObj.MovementCost;
                    transform.position = tileObj.GetConnectPoint().position;
                    AnimalColumn -= 1;
                }
            }                            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && IsSelected == true)
        {
            MapTile tileObj = mpGenertaor.GetTileAt(AnimalColumn, (AnimalRow + 1));
            if (tileObj.CanWalkOver == CanWalk || tileObj.CanSwimThrough == CanSwim || tileObj.CanFlyOver == CanFly)
            {
                if (MovementPoints - tileObj.MovementCost >= 0)
                {
                    MovementPoints -= tileObj.MovementCost;
                    transform.position = tileObj.GetConnectPoint().position;
                    AnimalRow += 1;
                }
            }                            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && IsSelected == true)
        {
            MapTile tileObj = mpGenertaor.GetTileAt(AnimalColumn, (AnimalRow - 1));
            if (tileObj.CanWalkOver == CanWalk || tileObj.CanSwimThrough == CanSwim || tileObj.CanFlyOver == CanFly)
            {
                if (MovementPoints - tileObj.MovementCost >= 0)
                {
                    MovementPoints -= tileObj.MovementCost;
                    transform.position = tileObj.GetConnectPoint().position;
                    AnimalRow -= 1;
                }
            }                        
        }
    }

    public void SelectUnit()
    {
        IsSelected = true;
    }

    public void UnselectUnit()
    {
        IsSelected = false;
        Debug.Log("unit deselected");
    }
    private void FightEnemy()
    {

    }
    private void InteractWithTile()
    {

    }
    public void ResetMovement()
    {
        MovementPoints = TotalPointsPerTurn;
    }
}
