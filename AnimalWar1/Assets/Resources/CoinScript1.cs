using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript1 : MonoBehaviour
{

    public AudioSource collectSound;
    public Vector3 pos;

    void Start()
    {
        //CreateRandomCoinAt();
    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);

    }

     void OnTriggerEnter(Collider other)
    {
        //This could change become add money
        //Add score
        collectSound.Play();
        ScoringSystem.theScore += 50;
        // Destroy Coin when we picked up
        Destroy(gameObject); 

    }
  
}
