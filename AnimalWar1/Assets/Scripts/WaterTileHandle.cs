using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTileHandle : MonoBehaviour
{
    public GameObject DeepWaterPrefab;
    public GameObject WaterPrefab;

    // Start is called before the first frame update
    void Start()
    {
       // GenerateWaterTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateWaterTiles()
    {
        GameObject newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x - 1, 0, DeepWaterPrefab.transform.position.z + 1);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x, 0, DeepWaterPrefab.transform.position.z + 1);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x + 1, 0, DeepWaterPrefab.transform.position.z + 1);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x - 1, 0, DeepWaterPrefab.transform.position.z);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x + 1, 0, DeepWaterPrefab.transform.position.z);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x - 1, 0, DeepWaterPrefab.transform.position.z - 1);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x, 0, DeepWaterPrefab.transform.position.z - 1);

        newWaterTile = Instantiate(WaterPrefab);
        newWaterTile.transform.position = new Vector3(DeepWaterPrefab.transform.position.x + 1, 0, DeepWaterPrefab.transform.position.z - 1);
    }
}
