 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{

    //Attributes

    //public float MoveSpeed
    //{
    //    get { return MoveSpeed; }
    //    set { MoveSpeed = value; }
    //}
    //public float Health
    //{
    //    get { return Health; }
    //    set { Health = value; }
    //}
    //public float Attack
    //{
    //    get { return Attack; }
    //    set { Attack = value; }
    //}
    //public float Armor
    //{
    //    get { return Armor; }
    //    set { Armor = value; }
    //}
    //public bool IsEnemy
    //{
    //    get { return IsEnemy; }
    //    set { IsEnemy = value; }
    //}
    //public bool CanSwim
    //{
    //    get { return CanSwim; }
    //    set { CanSwim = value; }
    //}
    //public bool CanFly
    //{
    //    get { return CanFly; }
    //    set { CanFly = value; }
    //}
    //public bool RangeAttack
    //{
    //    get { return RangeAttack; }
    //    set { RangeAttack = value; }
    //}
    //public int ResourceCost
    //{
    //    get { return ResourceCost; }
    //    set { ResourceCost = value; }
    //}

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
        //InstantiateAnimal(AnimalType.Deer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateAnimal(int switchNumber)
    {
        switch (switchNumber)
        {
            case 1:
                Debug.Log("You chose Wolf");
                var newWolf = Instantiate(Wolf, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var Script = newWolf.GetComponent<animalController>();
                //Script.MoveSpeed = 4;
                //Script.Health = 4;
                //Script.Attack = 4;
                //Script.Armor = 4;
                //Script.IsEnemy = false;
                //Script.CanSwim = false;
                //Script.CanFly = false;
                //Script.RangeAttack = false;
                break;

            case 2:
                Debug.Log("You chose Deer");
                var newDeer = Instantiate(Deer, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var Script1 = newDeer.GetComponent<animalController>();
                //Script1.MoveSpeed = 4;
                //Script1.Health = 4;
                //Script1.Attack = 4;
                //Script1.Armor = 4;
                //Script1.IsEnemy = false;
                //Script1.CanSwim = false;
                //Script1.CanFly = false;
                //Script1.RangeAttack = false;
                break;

            case 3:
                Debug.Log("You chose Moose");
                var newMoose = Instantiate(Moose, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var Script2 = newMoose.GetComponent<animalController>();
                //Script2.MoveSpeed = 4;
                //Script2.Health = 4;
                //Script2.Attack = 4;
                //Script2.Armor = 4;
                //Script2.IsEnemy = false;
                //Script2.CanSwim = false;
                //Script2.CanFly = false;
                //Script2.RangeAttack = false;
                break;

            case 4:
                Debug.Log("You choose Bear");
                var newBear = Instantiate(Bear, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var Script3 = newBear.GetComponent<animalController>();
                //Script3.MoveSpeed = 4;
                //Script3.Health = 4;
                //Script3.Attack = 4;
                //Script3.Armor = 4;
                //Script3.IsEnemy = false;
                //Script3.CanSwim = false;
                //Script3.CanFly = false;
                //Script3.RangeAttack = false;
                break;

            case 5:
                Debug.Log("You Chose Fox");
                var newFox = Instantiate(Fox, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var Script4 = newFox.GetComponent<animalController>();
                //Script4.MoveSpeed = 4;
                //Script4.Health = 4;
                //Script4.Attack = 4;
                //Script4.Armor = 4;
                //Script4.IsEnemy = false;
                //Script4.CanSwim = false;
                //Script4.CanFly = false;
                //Script4.RangeAttack = false;
                break;

            case 6:
                Debug.Log("You chose Boar");
                var newBoar = Instantiate(Boar, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var Script5 = newBoar.GetComponent<animalController>();
                //Script5.MoveSpeed = 4;
                //Script5.Health = 4;
                //Script5.Attack = 4;
                //Script5.Armor = 4;
                //Script5.IsEnemy = false;
                //Script5.CanSwim = false;
                //Script5.CanFly = false;
                //Script5.RangeAttack = false;
                break;

            //////////////////////////


            case 7:
                Debug.Log("You chose Dog");
                var newDog = Instantiate(Dog, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var eScript = newDog.GetComponent<animalController>();
                //eScript.MoveSpeed = 4;
                //eScript.Health = 4;
                //eScript.Attack = 4;
                //eScript.Armor = 4;
                //eScript.IsEnemy = false;
                //eScript.CanSwim = false;
                //eScript.CanFly = false;
                //eScript.RangeAttack = false;
                break;

            case 8:
                Debug.Log("You chose Cat");
                var newCat = Instantiate(Cat, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var eScript1 = newCat.GetComponent<animalController>();
                //eScript1.MoveSpeed = 4;
                //eScript1.Health = 4;
                //eScript1.Attack = 4;
                //eScript1.Armor = 4;
                //eScript1.IsEnemy = false;
                //eScript1.CanSwim = false;
                //eScript1.CanFly = false;
                //eScript1.RangeAttack = false;
                break;

            case 9:
                Debug.Log("You chose Bull");
                var newBull = Instantiate(Bull, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var eScript2 = newBull.GetComponent<animalController>();
                //eScript2.MoveSpeed = 4;
                //eScript2.Health = 4;
                //eScript2.Attack = 4;
                //eScript2.Armor = 4;
                //eScript2.IsEnemy = false;
                //eScript2.CanSwim = false;
                //eScript2.CanFly = false;
                //eScript2.RangeAttack = false;
                break;

            case 10:
                Debug.Log("You choose Rooster");
                var newRooster = Instantiate(Rooster, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var eScript3 = newRooster.GetComponent<animalController>();
                //eScript3.MoveSpeed = 4;
                //eScript3.Health = 4;
                //eScript3.Attack = 4;
                //eScript3.Armor = 4;
                //eScript3.IsEnemy = false;
                //eScript3.CanSwim = false;
                //eScript3.CanFly = false;
                //eScript3.RangeAttack = false;
                break;

            case 11:
                Debug.Log("You Chose Rabbit");
                var newRabbit = Instantiate(Rabbit, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var eScript4 = newRabbit.GetComponent<animalController>();
                //eScript4.MoveSpeed = 4;
                //eScript4.Health = 4;
                //eScript4.Attack = 4;
                //eScript4.Armor = 4;
                //eScript4.IsEnemy = false;
                //eScript4.CanSwim = false;
                //eScript4.CanFly = false;
                //eScript4.RangeAttack = false;
                break;

            case 12:
                Debug.Log("You chose Pig");
                var newPig = Instantiate(Pig, new Vector3(2.0f, 2.0f, 2.0f), Quaternion.identity);
                var eScript5 = newPig.GetComponent<animalController>();
                //eScript5.MoveSpeed = 4;
                //eScript5.Health = 4;
                //eScript5.Attack = 4;
                //eScript5.Armor = 4;
                //eScript5.IsEnemy = false;
                //eScript5.CanSwim = false;
                //eScript5.CanFly = false;
                //eScript5.RangeAttack = false;
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
    public void ClearAllAnimals()
    {
        GameObject[] WildAnimals = GameObject.FindGameObjectsWithTag("WildAnimal");
        foreach (GameObject Wild in WildAnimals)
            GameObject.Destroy(Wild);

        GameObject[] TameAnimals = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Tame in WildAnimals)
            GameObject.Destroy(Tame);
    }
}
