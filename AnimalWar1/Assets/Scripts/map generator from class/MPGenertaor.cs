using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPGenertaor : MonoBehaviour
{
    public int MapWidth;
    public int MapHeight;
    public int waterSeed;
    public int mountainSeed;
    public int forestSeed;
    public int rockSeed;
    public FillTileType FillTile;

    [System.Serializable]
    public enum TileType
    {
        DeepWater,
        Mountain,
        Forest,
        Rock
    }

    [System.Serializable]
    public struct TilePrefabEntry
    {
        public TileType type;
        public GameObject Prefab;
    }

    [System.Serializable]
    public enum FillTileType
    {
        Grass,
        Sand
    }

    [System.Serializable]
    public struct FillTilePrefabEntry
    {
        public FillTileType type;
        public GameObject Prefab;
    }

    public List<TilePrefabEntry> TilePrefabList;
    public List<FillTilePrefabEntry> FillTilePrefabList;    
    private List<MapTile> TileList = new List<MapTile>();

    public int GetMapWidth()
    {
        return MapWidth;
    }

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

    public void UpdateTileList(MapTile tile)
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
        for (int i = 0; i < waterSeed; i++)
        {
            // Get coord for new tile
            Xposition = Random.Range((int)MinX + 2, (int)MaxX - 2);
            Zposition = Random.Range((int)MinZ + 2, (int)MaxZ - 2);
            Column = (int)Xposition + (MapWidth / 2);
            Row = (int)-(Zposition - (MapWidth / 2));

            MapTile existingTile = GetTileAt(Column, Row);
            if (existingTile == null)
            {               
                // Spawn tile at new coord
                GameObject newTileObj = SpawnOtherTile(TileType.DeepWater, Xposition, Zposition);
                MapTile newTile = newTileObj.GetComponent<MapTile>();              


                // Set column and row on new tile
                newTile.Column = Column;
                newTile.Row = Row;

                // Update tile list with new tile
                UpdateTileList(newTile);

                // Call the function to build water directly in order to build water before fill tiles
                WaterTileHandle tileHandle = newTileObj.GetComponent<WaterTileHandle>();
                tileHandle.GenerateWaterTiles();
            }
                
        }

        // Spawn Mountain Tile
        for (int i = 0; i < mountainSeed; i++)
        {
            // Get coord for new tile
            Xposition = Random.Range((int)MinX + 2, (int)MaxX - 2);
            Zposition = Random.Range((int)MinZ + 2, (int)MaxZ - 2);
            Column = (int)Xposition + (MapWidth / 2);
            Row = (int)-(Zposition - (MapWidth / 2));

            MapTile existingTile = GetTileAt(Column, Row);
            if (existingTile == null)
            {
                // Spawn tile at new coord
                GameObject newTileObj = SpawnOtherTile(TileType.Mountain, Xposition, Zposition);
                MapTile newTile = newTileObj.GetComponent<MapTile>();


                // Set column and row on new tile
                newTile.Column = Column;
                newTile.Row = Row;

                // Update tile list with new tile
                UpdateTileList(newTile);
            }

        }

        // Spawn Forest Tile
        for (int i = 0; i < forestSeed; i++)
        {
            // Get coord for new tile
            Xposition = Random.Range((int)MinX + 2, (int)MaxX - 2);
            Zposition = Random.Range((int)MinZ + 2, (int)MaxZ - 2);
            Column = (int)Xposition + (MapWidth / 2);
            Row = (int)-(Zposition - (MapWidth / 2));

            MapTile existingTile = GetTileAt(Column, Row);
            if (existingTile == null)
            {
                // Spawn tile at new coord
                GameObject newTileObj = SpawnOtherTile(TileType.Forest, Xposition, Zposition);
                MapTile newTile = newTileObj.GetComponent<MapTile>();


                // Set column and row on new tile
                newTile.Column = Column;
                newTile.Row = Row;

                // Update tile list with new tile
                UpdateTileList(newTile);
            }

        }

        // Spawn Rock Tile
        for (int i = 0; i < rockSeed; i++)
        {
            // Get coord for new tile
            Xposition = Random.Range((int)MinX + 2, (int)MaxX - 2);
            Zposition = Random.Range((int)MinZ + 2, (int)MaxZ - 2);
            Column = (int)Xposition + (MapWidth / 2);
            Row = (int)-(Zposition - (MapWidth / 2));

            MapTile existingTile = GetTileAt(Column, Row);
            if (existingTile == null)
            {
                // Spawn tile at new coord
                GameObject newTileObj = SpawnOtherTile(TileType.Rock, Xposition, Zposition);
                MapTile newTile = newTileObj.GetComponent<MapTile>();


                // Set column and row on new tile
                newTile.Column = Column;
                newTile.Row = Row;

                // Update tile list with new tile
                UpdateTileList(newTile);

                // Call the function to build water directly in order to build water before fill tiles
                RockTileHandle tileHandle = newTileObj.GetComponent<RockTileHandle>();
                tileHandle.GenerateLittleRocks();
            }

        }

        // Reset Xposition and Zposition before spawning fill tile
        Xposition = MinX;
        Zposition = MaxZ;
        Column = 0;
        Row = 0;
        
        // Spawns Fill Tile
        while (Row < MapHeight)
        {
            while(Column < MapWidth)
            {
                MapTile existingTile = GetTileAt(Column, Row);
                if (existingTile == null)
                {
                    // Spawn new tile
                    GameObject newTileObj = SpawnFillTile(Xposition, Zposition);
                    MapTile newTile = newTileObj.GetComponent<MapTile>();
                    //Debug.Log("NewTile -- Column: " + Column + " Row: " + Row + " Spawned at (" + Xposition + "," + Zposition + ")");

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
        int tileIndex = Random.Range(0, TilePrefabList.Count);

        //Grab that 
        GameObject prefab = TilePrefabList[tileIndex].Prefab;

        //instantiate a prefab
        GameObject newTileObject = Instantiate(prefab);

        //position objject at psosition
        newTileObject.transform.position = new Vector3(x, 0, z);

        //return intatiated object
        return newTileObject;
    }
    
    private GameObject SpawnFillTile (float x, float z)
    {
        GameObject FillTileType = FillTilePrefabList[0].Prefab;

        switch (FillTile)
        {
            case (MPGenertaor.FillTileType.Grass):
                FillTileType = FillTilePrefabList[0].Prefab;
                break;
            case (MPGenertaor.FillTileType.Sand):
                FillTileType = FillTilePrefabList[1].Prefab;
                break;
        }

        // Spawn fill tile
        GameObject newTileObject = Instantiate(FillTileType);

        // Move fill tile to given coord
        newTileObject.transform.position = new Vector3(x, 0, z);

        // Return new fill tile
        return newTileObject;

    }

    private GameObject SpawnOtherTile (TileType type, float x, float z)
    {
        Vector3 spawnLocation = new Vector3(x, 0, z);

        switch (type)
        {
            case TileType.DeepWater:
                // Spawn new water tile
                GameObject newTileObject = Instantiate(TilePrefabList[0].Prefab);

                newTileObject.transform.position = spawnLocation;

                // Return new water tile
                return newTileObject;

            case TileType.Forest:
                // Spawn new water tile
                newTileObject = Instantiate(TilePrefabList[1].Prefab);

                newTileObject.transform.position = spawnLocation;

                // Return new water tile
                return newTileObject;

            case TileType.Mountain:
                // Spawn new water tile
                newTileObject = Instantiate(TilePrefabList[2].Prefab);

                newTileObject.transform.position = spawnLocation;

                // Return new water tile
                return newTileObject;

            case TileType.Rock:
                // Spawn new water tile
                newTileObject = Instantiate(TilePrefabList[3].Prefab);

                newTileObject.transform.position = spawnLocation;

                // Return new water tile
                return newTileObject;

            default:
                // Spawn new water tile
                newTileObject = Instantiate(TilePrefabList[0].Prefab);

                newTileObject.transform.position = spawnLocation;

                // Return new water tile
                return newTileObject;
        }
        
    }

    
}
