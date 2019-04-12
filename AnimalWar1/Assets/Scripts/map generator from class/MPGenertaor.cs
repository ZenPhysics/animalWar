using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPGenertaor : MonoBehaviour
{
    public int MapWidth;
    public int MapHeight;
    public int waterSeed;

    [System.Serializable]
    public enum TileType
    {
        Grass,
        DeepWater,
        Sand,
        Mountain,
        Forest,
        Rock
    }
    [System.Serializable]
    public struct TilePrefabEntry
    {
        public  TileType type;
        public GameObject Prefab;
    }
    
    public List<TilePrefabEntry> PrefabList;
    public TileType FillTile;
    public List<MapTile> TileList = new List<MapTile>();

    // Start is called before the first frame update
    void Start()
    {
        InitializeTileList();
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializeTileList()
    {
        //Set size for list based on map size
        int mapArea = MapHeight * MapWidth;
        for (int i = 0; i < mapArea; ++i)
        {
            //Set every entry in list to null
            TileList.Add(null);
        }
    }

    private void UpdateTileList(MapTile tile)
    {
        int index = tile.Row * MapWidth + tile.Column;
        TileList[index] = tile;
    }

    public void GenerateMap()
    {
        float MinX = -MapWidth/2;
        float MaxZ = MapHeight/2;
        float MaxX = MapWidth/2;
        float MinZ = -MapHeight/2;

        float Xposition = MinX;
        int Column = 0;
        float Zposition = MaxZ;
        int Row = 0;        
        
        //Spawns Water Tile
        for (int i = 0; i <= waterSeed; i++)
        {
            // Get coord for new tile
            Xposition = Random.Range((int)MinX + 1, (int)MaxX - 1);
            Zposition = Random.Range((int)MinZ + 1, (int)MaxZ - 1);

            // Spawn tile at new coord
            GameObject newTileObj = SpawnWaterTile(Xposition, Zposition);
            MapTile newTile = newTileObj.GetComponent<MapTile>();

            // Set column and row on new tile
            newTile.Column = (int)Xposition + (MapWidth / 2);
            newTile.Row = (int)-(Zposition - (MapWidth / 2));

            // Update tile list with new tile
            UpdateTileList(newTile);
        }
        
        // Reset Xposition and Zposition before spawning fill tile
        Xposition = MinX;
        Zposition = MaxZ;
        
        // Spawns Fill Tile
        while (Zposition >= MinZ)
        {
            while(Xposition <= MaxX)
            {
                MapTile existingTile = GetTileAt(Column, Row);
                if (existingTile == null)
                {
                    // Spawn new tile
                    GameObject newTileObj = SpawnFillTile(Xposition, Zposition);
                    MapTile newTile = newTileObj.GetComponent<MapTile>();

                    // Set column and row on new tile
                    newTile.Column = Column;
                    newTile.Row = Row;

                    // Update tile list with new tile
                    UpdateTileList(newTile);
                }
                Xposition++;
                Column++; 
            }
            Zposition--;
            Row++;
            
            Xposition = MinX;
            Column = 0;
        }
    }

    public MapTile GetTileAt (int col, int row)
    {
        // Gets index of given tile
        int index = row * MapWidth + col;

        // Grab given tile from tile list
        MapTile tile = TileList[index];

        // Return given tile
        return tile;
    }

    private GameObject CrateRandomTileAT(float x, float z)
    {
        //Create a random index to decide with prefab to create
        int tileIndex = Random.Range(0, PrefabList.Count);

        //Grab that 
        GameObject prefab = PrefabList[tileIndex].Prefab;

        //instantiate a prefab
        GameObject newTileObject = Instantiate(prefab);

        //position objject at psosition
        newTileObject.transform.position = new Vector3(x, 0, z);

        //return intatiated object
        return newTileObject;
    }
    
    private GameObject SpawnFillTile (float x, float z)
    {
        GameObject FillTileType = PrefabList[0].Prefab;

        switch (FillTile)
        {
            case (TileType.Grass):
                FillTileType = PrefabList[0].Prefab;
                break;
            case (TileType.Sand):
                FillTileType = PrefabList[2].Prefab;
                break;
        }

        // Spawn fill tile
        GameObject newTileObject = Instantiate(FillTileType);

        // Move fill tile to given coord
        newTileObject.transform.position = new Vector3(x, 0, z);

        // Return new fill tile
        return newTileObject;

    }

    private GameObject SpawnWaterTile (float x, float z)
    {
        // Spawn new water tile
        GameObject newTileObject = Instantiate(PrefabList[1].Prefab);

        // Move spawned water tile to given coord
        newTileObject.transform.position = new Vector3(x, 0, z);

        // Return new water tile
        return newTileObject;
    }

    
}
