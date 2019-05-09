using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public GameObject ResourceObject;
    public AudioSource collectSound;


    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

     void OnTriggerEnter(Collider other)
    {
        //Add score
        collectSound.Play();
        ScoringSystem.theScore += 50;
        // Destroy Coin when we picked up
        Destroy(gameObject); 

    }
}
