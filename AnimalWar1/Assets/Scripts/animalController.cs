using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalController : MonoBehaviour
{
    public int AnimalRow;
    public int AnimalColumn;

    public float MovementPoints;
    public float Health;
    public float Attack;
    public float Armor;
    public float size;
    public int intimidation;
    public int Anthem;
    public int ResourceCost;
    public bool IsEnemy;

    private MPGenertaor mpGenertaor;


    // Start is called before the first frame update
    void Start()
    {
        // Getting Reference To Map Generator in Able to Use Helper Functions
        var mapObj = GameObject.Find("MapManager");
        mpGenertaor = mapObj.GetComponent<MPGenertaor>();

        // Setting Up Columns and Rows Positions
        AnimalColumn = (int)transform.position.x + (mpGenertaor.GetMapWidth() / 2);
        AnimalRow = (int)-(transform.position.z - (mpGenertaor.GetMapWidth() / 2));        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MapTile tileObj = mpGenertaor.GetTileAt((AnimalColumn + 1), AnimalRow);
            if (MovementPoints - tileObj.MovementCost >= 0)
            {
                MovementPoints -= tileObj.MovementCost;
                transform.position = tileObj.GetConnectPoint().position;
                AnimalColumn += 1;
            }            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MapTile tileObj = mpGenertaor.GetTileAt((AnimalColumn - 1), AnimalRow);
            if (MovementPoints - tileObj.MovementCost >= 0)
            {
                MovementPoints -= tileObj.MovementCost;
                transform.position = tileObj.GetConnectPoint().position;
                AnimalColumn -= 1;
            }            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MapTile tileObj = mpGenertaor.GetTileAt(AnimalColumn, (AnimalRow - 1));
            if (MovementPoints - tileObj.MovementCost >= 0)
            {
                MovementPoints -= tileObj.MovementCost;
                transform.position = tileObj.GetConnectPoint().position;
                AnimalRow -= 1;
            }            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MapTile tileObj = mpGenertaor.GetTileAt(AnimalColumn, (AnimalRow + 1));
            if (MovementPoints - tileObj.MovementCost >= 0)
            {
                MovementPoints -= tileObj.MovementCost;
                transform.position = tileObj.GetConnectPoint().position;
                AnimalRow += 1;
            }            
        }
    }
    private void FightEnemy()
    {

    }
    private void InteractWithTile()
    {

    }
}
