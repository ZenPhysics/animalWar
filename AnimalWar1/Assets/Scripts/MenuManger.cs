using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour
{

    public bool isWild = true;
    public GameObject CanvasTame;
    public GameObject CanvasWild;

    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnOnMenu();
    }
    public void TurnOffMenu()
    {
        CanvasWild.SetActive(false);
        CanvasTame.SetActive(false);
        MainMenu.SetActive(false);
        Debug.Log("Turn off function called");
    }
    public void TurnOnMenu()
    {
        if (Input.GetKeyDown("space"))
        {
           
                Debug.Log("called Main Menu");
                MainMenu.SetActive(true);
            
        }
        
    }
    public void ChangeMenu()
    {
        isWild = !isWild;
    }
    public void CallTameMenu()
    {
        CanvasTame.SetActive(true);
    }
    public void CallWildMenu()
    {
        CanvasWild.SetActive(true);
    }
}
