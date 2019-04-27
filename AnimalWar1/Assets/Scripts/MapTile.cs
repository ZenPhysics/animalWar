using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTile : MonoBehaviour
{
    public Transform ConnectPoint;
    public int Column;
    public int Row;

    public float MovementCost;
    public bool CanWalkOver;
    public bool CanSwimThrough;
    public bool CanFlyOver;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetConnectPoint()
    {
        return ConnectPoint;
    }
}
