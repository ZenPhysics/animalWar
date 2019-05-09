using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemScript : MonoBehaviour
{
    public GameObject ResourceObject;
    public AudioSource GemtSound;
    public Vector3 pos3;

    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);

    }

    void OnTriggerEnter(Collider other)
    {
        //This could change become add money

        GemtSound.Play();
        ScoringSystem.theScore += 80;
        // Destroy Coin when we picked up
        Destroy(gameObject);

    }
}
