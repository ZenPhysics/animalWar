 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public GameObject Wolf;
    public GameObject Deer;
    public GameObject Moose;
    public GameObject Bear;
    public GameObject Fox;
    public GameObject Boar;
    

    public GameObject Dog;
    public GameObject Cat;
    public GameObject Bull;
    public GameObject Rooster;
    public GameObject Rabbit;
    public GameObject Pig;
    

    public int HomeSpawnCol;
    public int HomeSpawnRow;
    public int EnemySpawnCol;
    public int EnemySpawnRow;

    public Vector3 homeSpawn;
    public Vector3 enemySpawn;

    public GameObject ResourceObject;

    MPGenertaor mpGenertaor;


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

                AnimalList.AddAnimal(Script);
                ResourceObject.GetComponent<Resources>().PayMoneyWild(25);
             
                break;

            case 2:
                Debug.Log("You chose Deer");
                GameObject newDeer = Instantiate(Deer, enemySpawn, Quaternion.identity);
                animalController Script1 = newDeer.GetComponent<animalController>();

                Script1.AnimalColumn = EnemySpawnCol;
                Script1.AnimalRow = EnemySpawnRow;

                AnimalList.AddAnimal(Script1);
                ResourceObject.GetComponent<Resources>().PayMoneyWild(15);
                
                break;

            case 3:
                Debug.Log("You chose Moose");
                GameObject newMoose = Instantiate(Moose, enemySpawn, Quaternion.identity);
                animalController Script2 = newMoose.GetComponent<animalController>();

                Script2.AnimalColumn = EnemySpawnCol;
                Script2.AnimalRow = EnemySpawnRow;

                AnimalList.AddAnimal(Script2);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(26);
            
                break;

            case 4:
                Debug.Log("You choose Bear");
                GameObject newBear = Instantiate(Bear, enemySpawn, Quaternion.identity);
                animalController Script3 = newBear.GetComponent<animalController>();

                Script3.AnimalColumn = EnemySpawnCol;
                Script3.AnimalRow = EnemySpawnRow;

                AnimalList.AddAnimal(Script3);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(28);
               
                break;

            case 5:
                Debug.Log("You Chose Fox");
                GameObject newFox = Instantiate(Fox, enemySpawn, Quaternion.identity);
                animalController Script4 = newFox.GetComponent<animalController>();

                Script4.AnimalColumn = EnemySpawnCol;
                Script4.AnimalRow = EnemySpawnRow;

                AnimalList.AddAnimal(Script4);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(18);
              
                break;

            case 6:
                Debug.Log("You chose Boar");
                GameObject newBoar = Instantiate(Boar, enemySpawn, Quaternion.identity);
                animalController Script5 = newBoar.GetComponent<animalController>();

                Script5.AnimalColumn = EnemySpawnCol;
                Script5.AnimalRow = EnemySpawnRow;

                AnimalList.AddAnimal(Script5);

                ResourceObject.GetComponent<Resources>().PayMoneyWild(20);
                
                break;

            //////////////////////////


            case 7:
                Debug.Log("You chose Dog");
                GameObject newDog = Instantiate(Dog, homeSpawn, Quaternion.identity);
                animalController eScript = newDog.GetComponent<animalController>();

                eScript.AnimalColumn = HomeSpawnCol;
                eScript.AnimalRow = HomeSpawnRow;

                AnimalList.AddAnimal(eScript);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(27);
                
                break;

            case 8:
                Debug.Log("You chose Cat");
                GameObject newCat = Instantiate(Cat, homeSpawn, Quaternion.identity);
                animalController eScript1 = newCat.GetComponent<animalController>();

                eScript1.AnimalColumn = HomeSpawnCol;
                eScript1.AnimalRow = HomeSpawnRow;

                AnimalList.AddAnimal(eScript1);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(20);
              
                break;

            case 9:
                Debug.Log("You chose Bull");
                GameObject newBull = Instantiate(Bull, homeSpawn, Quaternion.identity);
                animalController eScript2 = newBull.GetComponent<animalController>();
                AnimalList.AddAnimal(eScript2);

                eScript2.AnimalColumn = HomeSpawnCol;
                eScript2.AnimalRow = HomeSpawnRow;

                

                ResourceObject.GetComponent<Resources>().PayMoneyTame(29);

                break;

            case 10:
                Debug.Log("You choose Rooster");
                GameObject newRooster = Instantiate(Rooster, homeSpawn, Quaternion.identity);
                animalController eScript3 = newRooster.GetComponent<animalController>();

                eScript3.AnimalColumn = HomeSpawnCol;
                eScript3.AnimalRow = HomeSpawnRow;

                AnimalList.AddAnimal(eScript3);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(19);
               
                break;

            case 11:
                Debug.Log("You Chose Rabbit");
                GameObject newRabbit = Instantiate(Rabbit, homeSpawn, Quaternion.identity);
                animalController eScript4 = newRabbit.GetComponent<animalController>();

                eScript4.AnimalColumn = HomeSpawnCol;
                eScript4.AnimalRow = HomeSpawnRow;

                AnimalList.AddAnimal(eScript4);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(18);
                
                break;

            case 12:
                Debug.Log("You chose Pig");
                GameObject newPig = Instantiate(Pig, homeSpawn, Quaternion.identity);
                animalController eScript5 = newPig.GetComponent<animalController>();

                eScript5.AnimalColumn = HomeSpawnCol;
                eScript5.AnimalRow = HomeSpawnRow;

                AnimalList.AddAnimal(eScript5);

                ResourceObject.GetComponent<Resources>().PayMoneyTame(20);
             
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
