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

    public void GenerateLittleRocks(MapTile tile)
    {
        var mpObj = GameObject.Find("MapManager");
        mpGenertaor = mpObj.GetComponent<MPGenertaor>();        

        //----------- Needs To Be Condensed Down To Loops -----------//

        MapTile ExistingTile = mpGenertaor.GetTileAt(tile.Column - 1, tile.Row);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(tile.transform.position.x - 1, 0, tile.transform.position.z);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = tile.Column - 1;
            newTile.Row = tile.Row;

            mpGenertaor.UpdateTileList(newTile);
        }

        ExistingTile = mpGenertaor.GetTileAt(tile.Column, tile.Row + 1);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(tile.transform.position.x, 0, tile.transform.position.z - 1);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = tile.Column;
            newTile.Row = tile.Row + 1;

            mpGenertaor.UpdateTileList(newTile);
        }

        ExistingTile = mpGenertaor.GetTileAt(tile.Column + 1, tile.Row);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(tile.transform.position.x + 1, 0, tile.transform.position.z);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = tile.Column + 1;
            newTile.Row = tile.Row;

            mpGenertaor.UpdateTileList(newTile);
        }

        ExistingTile = mpGenertaor.GetTileAt(tile.Column, tile.Row - 1);
        if (ExistingTile == null)
        {
            GameObject newLittleRockTile = Instantiate(LittleRockPrefab);
            newLittleRockTile.transform.position = new Vector3(tile.transform.position.x, 0, tile.transform.position.z + 1);

            MapTile newTile = newLittleRockTile.GetComponent<MapTile>();
            newTile.Column = tile.Column;
            newTile.Row = tile.Row - 1;

            mpGenertaor.UpdateTileList(newTile);
        }
    }       

        
    
    
}

