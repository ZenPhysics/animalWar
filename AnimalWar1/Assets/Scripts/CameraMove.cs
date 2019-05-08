using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float CameraSpeed = 5.0f;
    public float scroll = 2.0f;
    public float zoomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //Zoom

        //float scroll = Input.GetAxis("Mouse ScrollWheel");
        //transform.Translate(0, scroll * zoomSpeed, scroll * zoomSpeed, Space.World);

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            transform.Translate(0, scroll * zoomSpeed, scroll * zoomSpeed, Space.World);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            transform.Translate(0, scroll * zoomSpeed, scroll * zoomSpeed, Space.World);
        }

        //Movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * CameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * CameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * CameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * CameraSpeed * Time.deltaTime;
        }
    }
}

