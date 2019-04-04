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
        WAter,
        Dirt,
        Mountain,
        Forest,
        Building

    }
    [System.Serializable]
    public struct TilePrefabEntry
    {
       public  TileType type;
        public GameObject Prefab;
    }

    public List<TilePrefabEntry> PrefabList;

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateMap()
    {
        float MinX = -MapWidth/2;
        float MaxZ = MapHeight/2;
        float MaxX = MapWidth/2;
        float MinZ = -MapHeight/2;

        float Xposition = MinX;
        int Column = 0;
        float Zposition = MaxZ;
        int Row = 0;

        while(Zposition >= MinZ)
        {
            while(Xposition <= MaxX)
            {
                GameObject newTileObj = CrateRandomTileAT(Xposition, Zposition);
                MapTile newTile = newTileObj.GetComponent<MapTile>();


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

    
}
