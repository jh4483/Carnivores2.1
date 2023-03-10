using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

private GameObject mainCam;
private float moveSpeed = 5.0f;
private float zoomedFieldOfView = 20f;
private float defaultFieldOfView = 60f;
private bool isZoomed;

    void Start()
    {
        mainCam = GameObject.Find("Main Camera");
        isZoomed = false;
    }

    void Update()
    {
        if(Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey("down"))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(-Vector3.left * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("w")) 
        {
            transform.Rotate(0.05f, 0, 0);
        }

        if (Input.GetKey("a")) 
        {
            transform.Rotate(0, -0.05f, 0);
        }

        if (Input.GetKey("s")) 
        {
            transform.Rotate(-0.05f, 0, 0);
        }

        if (Input.GetKey("d")) 
        {
            transform.Rotate(0,0.05f, 0);
        }  

        if(Input.GetKeyDown(KeyCode.B))
        {           
            Debug.Log(isZoomed);
            isZoomed = !isZoomed;
            ZoomCamera();
        }  

    }

    public void ZoomCamera()
    {
        if(isZoomed)
        {
            GetComponent<Camera>().fieldOfView = zoomedFieldOfView;
        }
        else
        {
            GetComponent<Camera>().fieldOfView = defaultFieldOfView;
        } 
    }

}
