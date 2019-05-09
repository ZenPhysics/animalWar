using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum PointType
{
    Coin,
    Diamond,
    Gem
}

[System.Serializable]
public struct PointPrefabEntry
{
    public PointType Type;
    public GameObject Prefab;
}
public class PointManager : MonoBehaviour
{
    public List<PointPrefabEntry> PointList;
   // public PointType FillTile;
    public int MapWidth;
    public int MapHeight;

    // Start is called before the first frame update
    void Start()
        {
               for(int i=0;i< MapWidth/2; i++)
            {
               GenerateCoin();

            }
        }


    private void GenerateCoin()
    {

        float XPos = Random.Range(-8, 8);
        //int Column = 0;
        float ZPos = Random.Range(-8, 8);
        //int Row = 0;

        GameObject newPointObj = CreateRandomCoinAt(XPos, ZPos);

    }
        private GameObject CreateRandomCoinAt(float XPos , float ZPos)
        {
            //Generate a random index to decide which prefab to create
            int tileIndex = Random.Range(0, 3);//0:Coin 1:Diamond 2:Gem

        //Grab that prefab from the list
        GameObject prefab = PointList[tileIndex].Prefab;

            //Create an instance of the prefab
        GameObject newPointObj = Instantiate(prefab);

            //Place the new object at the desired x and z position
            newPointObj.transform.position = new Vector3(XPos, 0.2f, ZPos);

            //Return the new instance object
            return newPointObj;


        }
    }   