using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{

    //Attributes

    public float MoveSpeed;
    public float Health;
    public float Attack;
    public float Armor;
    public bool isEnemy;

    enum SpecialAttacks
    {

    }

    enum AnimalType
    {
        Wolf,
        Deer,
        Moose,
        Bear,
        Fox,
        Boar,

        Dog,
        Cat,
        Bull,
        Rooster,
        Rabbit,
        Pig
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void instantiate(AnimalType animal)
    {
        switch (animal)
        {
            case AnimalType.Wolf:
                Debug.Log("You choose Wolf");
                break;

            case AnimalType.Deer:
                Debug.Log("You choose Deer");
                break;

            case AnimalType.Moose:
                Debug.Log("You choose Moose");
                break;

            case AnimalType.Bear:
                Debug.Log("You choose  2");
                break;

            case AnimalType.Fox:
                Debug.Log("Case 2");
                break;

            case AnimalType.Boar:
                Debug.Log("Case 2");
                break;


            default:
                Debug.Log("Default case");
                break;



        }
    }
}
