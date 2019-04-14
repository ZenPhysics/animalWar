using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTileHandle : MonoBehaviour
{
    public GameObject RockPrefab;
    public GameObject LittleRockPrefab;
    //public GameObject SandPrefab;

    private MPGenertaor mpGenertaor;
    private MapTile RockTile;

    // Start is called before the first frame update
    void Start()
    {        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateLittleRocks()
    {
        var mpObj = GameObject.Find("MapManager");
        mpGenertaor = mpObj.GetComponent<MPGenertaor>();

        RockTile = RockPrefab.GetComponent<MapTile>();

        //-------------- Hand Coded With Magic Numbers --------------//
        //----------- Needs To Be Condensed Down To Loops -----------//

        MapTile ExistingTile = mpGenertaor.GetTileAt(RockTile.Column - 1, RockTile.Row);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(RockPrefab.transform.position.x - 1, 0, RockPrefab.transform.position.z);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = RockTile.Column - 1;
            newTile.Row = RockTile.Row;

            mpGenertaor.UpdateTileList(newTile);
        }

        ExistingTile = mpGenertaor.GetTileAt(RockTile.Column, RockTile.Row + 1);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(RockPrefab.transform.position.x, 0, RockPrefab.transform.position.z + 1);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = RockTile.Column;
            newTile.Row = RockTile.Row + 1;

            mpGenertaor.UpdateTileList(newTile);
        }

        ExistingTile = mpGenertaor.GetTileAt(RockTile.Column + 1, RockTile.Row);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(RockPrefab.transform.position.x + 1, 0, RockPrefab.transform.position.z);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = RockTile.Column + 1;
            newTile.Row = RockTile.Row;

            mpGenertaor.UpdateTileList(newTile);
        }

        ExistingTile = mpGenertaor.GetTileAt(RockTile.Column, RockTile.Row - 1);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(RockPrefab.transform.position.x, 0, RockPrefab.transform.position.z - 1);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = RockTile.Column;
            newTile.Row = RockTile.Row - 1;

            mpGenertaor.UpdateTileList(newTile);
        }
    }       

        
    
    
}

