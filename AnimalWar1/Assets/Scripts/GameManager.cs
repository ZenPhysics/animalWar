using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    GameObject PreviousUnit = null;
    GameObject CurrentUnit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            GameObject unitRef = IsMouseOnUnit(Input.mousePosition);

            if (unitRef != null)
            {
                if (PreviousUnit != null)
                {
                    animalController previousController = PreviousUnit.GetComponent<animalController>();
                    previousController.UnselectUnit();
                }
                CurrentUnit = unitRef;
                animalController controller = CurrentUnit.GetComponent<animalController>();
                controller.SelectUnit();
                PreviousUnit = CurrentUnit;
            }
        }
    }

    private GameObject IsMouseOnUnit(Vector3 mousePos)
    {
        RaycastHit hitPoint;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        if (Physics.Raycast(ray, out hitPoint, Mathf.Infinity))
        {
            if (hitPoint.collider.tag == "WildAnimal" || hitPoint.collider.tag == "TameAnimal")
            {
                Debug.Log("Hit Unit");
                GameObject unityRef = hitPoint.transform.gameObject;
                return unityRef;
            }
        }
        else
        {
            Debug.Log("No Collider Hit");
            return null;
        }
        return null;
    }
}
