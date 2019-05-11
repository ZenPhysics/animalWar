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
    

    public GameObject Wolf;
    
    public GameObject Moose;
    public GameObject Bear;
    public GameObject Fox;
    public GameObject Deer;
    public GameObject Boar;
    

    public GameObject Dog;
    public GameObject Cat;
    public GameObject Bull;
    public GameObject Rooster;
    public GameObject Pig;
    public GameObject Rabbit;

    public int HomeSpawnCol;
    public int HomeSpawnRow;
    public int EnemySpawnCol;
    public int EnemySpawnRow;

    public Vector3 homeSpawn;
    public Vector3 enemySpawn;

    public GameObject ResourceObject;

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
    MPGenertaor mpGenertaor;

    public List<animalController> animalList = new List<animalController>();
    // Start is called before the first frame update
    void Start()
    {
        ResourceObject = GameObject.FindGameObjectWithTag("Resource");

        var mapObj = GameObject.Find("MapManager");
        mpGenertaor = mapObj.GetComponent<MPGenertaor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateAnimal(int switchNumber)
    {
        homeSpawn = mpGenertaor.GetTileAt(HomeSpawnCol, HomeSpawnRow).transform.position;
        enemySpawn = mpGenertaor.GetTileAt(EnemySpawnCol, EnemySpawnRow).transform.position;
        switch (switchNumber)
        {
            
            case 1:
                Debug.Log("You chose Wolf");
                GameObject newWolf = Instantiate(Wolf);
                newWolf.transform.position = enemySpawn;
                animalController Script = newWolf.GetComponent<animalController>();

                Script.AnimalColumn = EnemySpawnCol;
                Script.AnimalRow = EnemySpawnRow;

                animalList.Add(Script);
                ResourceObject.GetComponent<Resources>().PayMoneyWild(25);
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
                GameObject newDeer = Instantiate(Deer, enemySpawn, Quaternion.identity);
                animalController Script1 = newDeer.GetComponent<animalController>();

                Script1.AnimalColumn = EnemySpawnCol;
                Script1.AnimalRow = EnemySpawnRow;

                animalList.Add(Script1);
                ResourceObject.GetComponent<Resources>().PayMoneyWild(15);
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
                GameObject newMoose = Instantiate(Moose, enemySpawn, Quaternion.identity);
                animalController Script2 = newMoose.GetComponent<animalController>();

                Script2.AnimalColumn = EnemySpawnCol;
                Script2.AnimalRow = EnemySpawnRow;

                animalList.Add(Script2);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(26);
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
                GameObject newBear = Instantiate(Bear, enemySpawn, Quaternion.identity);
                animalController Script3 = newBear.GetComponent<animalController>();

                Script3.AnimalColumn = EnemySpawnCol;
                Script3.AnimalRow = EnemySpawnRow;

                animalList.Add(Script3);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(28);
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
                GameObject newFox = Instantiate(Fox, enemySpawn, Quaternion.identity);
                animalController Script4 = newFox.GetComponent<animalController>();

                Script4.AnimalColumn = EnemySpawnCol;
                Script4.AnimalRow = EnemySpawnRow;

                animalList.Add(Script4);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(18);
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
                GameObject newBoar = Instantiate(Boar, enemySpawn, Quaternion.identity);
                animalController Script5 = newBoar.GetComponent<animalController>();

                Script5.AnimalColumn = EnemySpawnCol;
                Script5.AnimalRow = EnemySpawnRow;

                animalList.Add(Script5);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(20);
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
                GameObject newDog = Instantiate(Dog, homeSpawn, Quaternion.identity);
                animalController eScript = newDog.GetComponent<animalController>();

                eScript.AnimalColumn = HomeSpawnCol;
                eScript.AnimalRow = HomeSpawnRow;

                animalList.Add(eScript);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(27);
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
                GameObject newCat = Instantiate(Cat, homeSpawn, Quaternion.identity);
                animalController eScript1 = newCat.GetComponent<animalController>();

                eScript1.AnimalColumn = HomeSpawnCol;
                eScript1.AnimalRow = HomeSpawnRow;

                animalList.Add(eScript1);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(20);
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
                GameObject newBull = Instantiate(Bull, homeSpawn, Quaternion.identity);
                animalController eScript2 = newBull.GetComponent<animalController>();

                eScript2.AnimalColumn = HomeSpawnCol;
                eScript2.AnimalRow = HomeSpawnRow;

                animalList.Add(eScript2);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(29);



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
                GameObject newRooster = Instantiate(Rooster, homeSpawn, Quaternion.identity);
                animalController eScript3 = newRooster.GetComponent<animalController>();

                eScript3.AnimalColumn = HomeSpawnCol;
                eScript3.AnimalRow = HomeSpawnRow;

                animalList.Add(eScript3);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(19);
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
                GameObject newRabbit = Instantiate(Rabbit, homeSpawn, Quaternion.identity);
                animalController eScript4 = newRabbit.GetComponent<animalController>();

                eScript4.AnimalColumn = HomeSpawnCol;
                eScript4.AnimalRow = HomeSpawnRow;

                animalList.Add(eScript4);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(18);
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
                GameObject newPig = Instantiate(Pig, homeSpawn, Quaternion.identity);
                animalController eScript5 = newPig.GetComponent<animalController>();

                eScript5.AnimalColumn = HomeSpawnCol;
                eScript5.AnimalRow = HomeSpawnRow;

                animalList.Add(eScript5);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(20);
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

        GameObject[] TameAnimals = GameObject.FindGameObjectsWithTag("TameAnimal");
        foreach (GameObject Tame in TameAnimals)
            GameObject.Destroy(Tame);
    }

    public void SetHomeSpawn(int col, int row)
    {
        HomeSpawnCol = col;
        HomeSpawnRow = row;
    }
    public void SetEnemySpawn(int col, int row)
    {
        EnemySpawnCol = col;
        EnemySpawnRow = row;
    }
}
