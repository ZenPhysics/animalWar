using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public GameObject ResourceObject;
    public AudioSource collectSound;

    private void Start()
    {
        ResourceObject = GameObject.FindGameObjectWithTag("Resource");
    }

    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

     void OnTriggerEnter(Collider other)
    {
        //Add score
        collectSound.Play();

        if (other.gameObject.tag == "WildAnimal")
        {
            ResourceObject.GetComponent<Resources>().AddMoneyWild();
        }
        else if (other.gameObject.tag == "TameAnimal")
        {
            ResourceObject.GetComponent<Resources>().AddMoneyTame();

        }
        Destroy(gameObject);

    }
}
