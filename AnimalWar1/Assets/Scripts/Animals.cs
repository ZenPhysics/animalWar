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

    public Transform Wolf;
    public Transform Deer;
    public Transform Moose;
    public Transform Bear;
    public Transform Fox;
    public Transform Boar;

    public Transform Dog;
    public Transform Cat;
    public Transform Bull;
    public Transform Rooster;
    public Transform Rabbit;
    public Transform Pig;

    enum SpecialAttacks
    {

    }

    public enum AnimalType
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
        InstantiateAnimal(AnimalType.Deer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstantiateAnimal(AnimalType animal)
    {
        switch (animal)
        {
            case AnimalType.Wolf:
                Debug.Log("You chose Wolf");
                Instantiate(Wolf, new Vector3(2.0f,2.0f,2.0f) , Quaternion.identity);
                break;

            case AnimalType.Deer:
                Debug.Log("You chose Deer");
                Instantiate(Deer, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                break;

            case AnimalType.Moose:
                Debug.Log("You chose Moose");
                Instantiate(Moose, transform.position, Quaternion.identity);
                break;

            case AnimalType.Bear:
                Debug.Log("You choose Bear");
                Instantiate(Bear, transform.position, Quaternion.identity);
                break;

            case AnimalType.Fox:
                Debug.Log("You Chose Fox");
                Instantiate(Fox, transform.position, Quaternion.identity);
                break;

            case AnimalType.Boar:
                Debug.Log("You chose Boar");
                Instantiate(Boar, transform.position, Quaternion.identity);
                break;

                ////////////////////////


            case AnimalType.Dog:
                Debug.Log("You chose Dog");
                Instantiate(Dog, transform.position, Quaternion.identity);
                break;

            case AnimalType.Cat:
                Debug.Log("You chose Cat");
                Instantiate(Cat, transform.position, Quaternion.identity);
                break;

            case AnimalType.Bull:
                Debug.Log("You chose Bull");
                Instantiate(Bull, transform.position, Quaternion.identity);
                break;

            case AnimalType.Rooster:
                Debug.Log("You choose Rooster");
                Instantiate(Rooster, transform.position, Quaternion.identity);
                break;

            case AnimalType.Rabbit:
                Debug.Log("You Chose Rabbit");
                Instantiate(Rabbit, transform.position, Quaternion.identity);
                break;

            case AnimalType.Pig:
                Debug.Log("You chose Pig");
                Instantiate(Pig, transform.position, Quaternion.identity);
                break;


            default:
                Debug.Log("Not an animal");
                break;



        }
    }
    public void TestInstantiate()
    {
        Instantiate(Wolf, new Vector3(4.0f, 4.0f, 4.0f), Quaternion.identity);
    }
}
