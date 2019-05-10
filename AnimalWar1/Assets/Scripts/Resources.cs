using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
    private float TameGold;
    private int WildGold;
    public Text WildGoldText;
    public Text TameGoldText;

    // Start is called before the first frame update
    void Start()
    {
        TameGold = 100;
        WildGold = 100;
        ShowMoney();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void AddMoney()
    {
        TameGold += (25); 
        WildGold += (25); 
        ShowMoney();
    }
    public void ShowMoney()
    {
        WildGoldText.text = ("WildGold = " + WildGold);
        TameGoldText.text = ("TameGold = " + TameGold);
    }
    void ResetMoney()
    {
        TameGold = 100;
        WildGold = 100;
    }
    public void AddMoneyTame()
    {
        TameGold += (25); 
        ShowMoney();
    }
    public void AddMoneyWild()
    {
        WildGold += (25); 
        ShowMoney();
    }
    public void PayMoneyWild(int pointCost)
    {
        WildGold -= (pointCost);
        ShowMoney();
    }
    public void PayMoneyTame(int pointCost)
    {
        TameGold -= (pointCost); 
        ShowMoney();
    }



}
