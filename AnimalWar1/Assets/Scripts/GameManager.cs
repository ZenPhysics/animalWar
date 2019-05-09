using UnityEngine;

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

            Debug.Log("Mouse Was clicked, unit ref" + (unitRef == null ? "NULL" : "NOT NULL"));

            if (unitRef != null)
            {
                Debug.Log("Mouse is over a unit");
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
        // Bit shift the index of the layer (9) to get a bit mask for animal layer
        int layerMask = 1 << 9;
        if (Physics.Raycast(ray, out hitPoint, Mathf.Infinity, layerMask))
        {
            if (hitPoint.collider.tag == "WildAnimal" || hitPoint.collider.tag == "TameAnimal")
            {
                Debug.Log("Hit Unit");
                GameObject unityRef = hitPoint.transform.gameObject;
                return unityRef;
            }
            else
            {
                Debug.Log("Ray hit something, but it wasn't an animal");
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
