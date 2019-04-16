using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour
{

    public bool isWild = true;
    public GameObject CanvasTame;
    public GameObject CanvasWild;

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
        Debug.Log("Turn off function called");
        //GameObject.Find("UICanvasTame").SetActive(false);
        //GameObject.Find("UICanvasWild").SetActive(false);
    }
    public void TurnOnMenu()
    {
        if (Input.GetKeyDown("space"))
        {
            if(isWild)
            {
                Debug.Log("called wild cancvas");
                CanvasWild.SetActive(true);
            }
            else
            {
                Debug.Log("called tame canvas");
                CanvasTame.SetActive(true);
            }          
            //("UICanvasWild").SetActive(true);
        }
    }
}
