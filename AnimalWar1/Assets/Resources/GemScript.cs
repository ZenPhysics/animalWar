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
        ResourceObject = GameObject.FindGameObjectWithTag("Resource");
    }
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);

    }

    void OnTriggerEnter(Collider other)
    {
        //This could change become add money

        GemtSound.Play();
        if (other.gameObject.tag == "WildAnimal")
        {
            ResourceObject.GetComponent<Resources>().AddMoneyWild();
            ResourceObject.GetComponent<Resources>().AddMoneyWild();
        }
        else if (other.gameObject.tag == "TameAnimal")
        {
            ResourceObject.GetComponent<Resources>().AddMoneyTame();
            ResourceObject.GetComponent<Resources>().AddMoneyTame();

        }
        Destroy(gameObject);

    }
}
