using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundWorld : MonoBehaviour
{
    float left = Screen.width;
    float right = Screen.width;
    float bottom = Screen.height;
    float top = Screen.height;
    Camera cam;
    float distanceZ;

    void Start()
    {
        cam = Camera.main;
        distanceZ = cam.transform.position.z - transform.position.z;

        left = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        right = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        bottom= cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).y;
        top = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, distanceZ)).y;
    }



    void FixedUpdate()
    {
        if (transform.position.x < left)
        {
            transform.position = new Vector3(right, transform.position.y, transform.position.z);
        }

        if (transform.position.x > right)
        {
            transform.position = new Vector3(left, transform.position.y, transform.position.z);
        }

        if (transform.position.y < bottom)
        {
            transform.position = new Vector3(transform.position.x, top, transform.position.z);
        }

        if (transform.position.y > top)
        {
            transform.position = new Vector3(transform.position.x, bottom, transform.position.z);
        }
    }
}
