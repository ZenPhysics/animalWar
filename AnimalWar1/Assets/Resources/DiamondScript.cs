using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DiamondScript : MonoBehaviour
{
    public GameObject ResourceObject;
    public AudioSource DiamondSound;
    public Vector3 pos2;

    void Start()
    {
        ResourceObject = GameObject.FindGameObjectWithTag("Resource");
    }
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);

    }

    void OnTriggerEnter(Collider other)
    {

       // if(other.gameObject = gameObject.FindObjectwithtag<Enem)
        //Add score
        DiamondSound.Play();

        //Destroy(gameObject);

        if (other.gameObject.tag == "WildAnimal")
        {
            ResourceObject.GetComponent<Resources>().AddMoneyWild();
            ResourceObject.GetComponent<Resources>().AddMoneyWild();
            ResourceObject.GetComponent<Resources>().AddMoneyWild();
        }
        else if(other.gameObject.tag == "TameAnimal")
        {
            ResourceObject.GetComponent<Resources>().AddMoneyTame();
            ResourceObject.GetComponent<Resources>().AddMoneyTame();
            ResourceObject.GetComponent<Resources>().AddMoneyTame();

        }
        Destroy(gameObject);



        //ResourceObject.GetComponent<Resources>().AddMoneyWild();

        //ScoringSystem.theScore += 100;
        // Destroy Coin when we picked up
        // Destroy(gameObject);

    }
   
}
