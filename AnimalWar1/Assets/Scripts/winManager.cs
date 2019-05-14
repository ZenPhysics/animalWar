using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //This could change become add money
        //Add score
        if(other.tag == "WildAnamal")
        {

        }
        //collectSound.Play();

        //ScoringSystem.theScore += 50;
        //// Destroy Coin when we picked up
        //Destroy(gameObject);

    }
}
