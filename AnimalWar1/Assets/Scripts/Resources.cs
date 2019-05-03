using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
    private float TameGold;
    private int WildGold;
    private float elapsed;
    public Text WildGoldText;
    public Text TameGoldText;
    public int WildResourceTilesControlled;
    public int TameResourceTilesControlled;

    // Start is called before the first frame update
    void Start()
    {
        TameGold = 100;
        WildGold = 100;
        elapsed = 0f;
        WildResourceTilesControlled = 5;
        TameResourceTilesControlled = 1;
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            AddMoney();
            ShowMoney();
        }
    }

    void AddMoney()
    {
        TameGold += (1 * WildResourceTilesControlled);
        WildGold += (1 * TameResourceTilesControlled);
    }
    void ShowMoney()
    {
       // Debug.Log("TameGold = " + TameGold);
        //Debug.Log("WildGold = " + WildGold);
        WildGoldText.text = ("TameGold = " + TameGold);
        TameGoldText.text = ("WildGold = " + WildGold);
    }
    void ResetMoney()
    {
        TameGold = 100;
        WildGold = 100;
    }
}
