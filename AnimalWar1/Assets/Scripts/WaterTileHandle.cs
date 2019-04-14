using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTileHandle : MonoBehaviour
{
    public GameObject DeepWaterPrefab;
    public GameObject WaterPrefab;

    private MapTile DeepWaterTile;
    private MPGenertaor mpGenertaor;

    // Start is called before the first frame update
    void Start()
    {
        //GenerateWaterTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateWaterTiles()
    {
        var mpObj = GameObject.Find("MapManager");
        mpGenertaor = mpObj.GetComponent<MPGenertaor>();

        DeepWaterTile = DeepWaterPrefab.GetComponent<MapTile>();
        
        int x = -1;
        int z = 1;

        for (z = 1; z >= -1; z--)
        {
            for (x = -1; x <= 1; x++)
            {
                MapTile ExistingTile = mpGenertaor.GetTileAt(DeepWaterTile.Column + x, DeepWaterTile.Row + z);
                if (ExistingTile == null)
                {
                    GameObject newWaterTile = Instantiate(WaterPrefab);
                    newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x + x, 0, DeepWaterPrefab.transform.position.z - z);                    

                    MapTile newTile = newWaterTile.GetComponent<MapTile>();
                    newTile.Column = DeepWaterTile.Column + x;
                    newTile.Row = DeepWaterTile.Row + z;

                    mpGenertaor.UpdateTileList(newTile);
                }
                
            }

        }
        
    }
}
