using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPGenertaor : MonoBehaviour
{
    public int MapWidth;
    public int MapHeight;

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

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
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

        int tileIndex = 0;

        while(Zposition >= MinZ)
        {
            while(Xposition <= MaxX)
            {
                tileIndex = Random.Range(1, 50);
                if (tileIndex == 1 || tileIndex == 3 || tileIndex == 4 || tileIndex == 5)
                {
                   GameObject newTileObj = SpawnOtherTiles(tileIndex, Xposition, Zposition);
                   MapTile newTile = newTileObj.GetComponent<MapTile>();
                }
                else
                {
                    GameObject newTileObj = SpawnFillTile(Xposition, Zposition);
                    MapTile newTile = newTileObj.GetComponent<MapTile>();
                }
                


                Xposition++;
                Column++;
            }
            //Do Stuff
            Zposition--;
            Row++;
            Xposition = MinX;
            Column = 0;
        }
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

        GameObject newTileObject = Instantiate(FillTileType);

        newTileObject.transform.position = new Vector3(x, 0, z);

        return newTileObject;

    }

    private GameObject SpawnOtherTiles (int tileIndex, float x, float z)
    {
        switch (tileIndex)
        {
            case 1:
                GameObject newTileObject = Instantiate(PrefabList[1].Prefab);
                newTileObject.transform.position = new Vector3(x+1, 0, z-1);
                return newTileObject;
            case 3:
                newTileObject = Instantiate(PrefabList[3].Prefab);
                newTileObject.transform.position = new Vector3(x, 0, z);
                return newTileObject;
            case 4:
                newTileObject = Instantiate(PrefabList[4].Prefab);
                newTileObject.transform.position = new Vector3(x, 0, z);
                return newTileObject;
            case 5:
                newTileObject = Instantiate(PrefabList[5].Prefab);
                newTileObject.transform.position = new Vector3(x+1, 0, z-1);
                return newTileObject;
            default:
                newTileObject = Instantiate(PrefabList[0].Prefab);
                newTileObject.transform.position = new Vector3(x, 0, z);
                return newTileObject;
        }
    }

    
}
