using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTileHandle : MonoBehaviour
{
    public enum RockTileType
    {
        Rock,
        LittleRock,
        Sand
    }

    public GameObject RockPrefab;
    public GameObject LittleRockPrefab;
    public GameObject SandPrefab;
    public RockTileType type;

    // Start is called before the first frame update
    void Start()
    {        
        switch (type)
        {
            case RockTileType.Rock:
                GenerateLittleRocks();
                break;
            case RockTileType.LittleRock:
                //GenerateSand();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateLittleRocks()
    {
        GameObject newTileObject = Instantiate(LittleRockPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x + 1, 0, RockPrefab.transform.position.z    );

        newTileObject = Instantiate(LittleRockPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x - 1, 0, RockPrefab.transform.position.z    );

        newTileObject = Instantiate(LittleRockPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x,     0, RockPrefab.transform.position.z + 1);

        newTileObject = Instantiate(LittleRockPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x,     0, RockPrefab.transform.position.z - 1);
    }
    /*
    private void GenerateSand()
    {
        GameObject newTileObject = Instantiate(SandPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x + 1, 0, RockPrefab.transform.position.z + 1);

        newTileObject = Instantiate(SandPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x + 1, 0, RockPrefab.transform.position.z - 1);

        newTileObject = Instantiate(SandPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x - 1, 0, RockPrefab.transform.position.z + 1);

        newTileObject = Instantiate(SandPrefab);
        newTileObject.transform.position = new Vector3(RockPrefab.transform.position.x - 1, 0, RockPrefab.transform.position.z - 1);
    }
    */
}

