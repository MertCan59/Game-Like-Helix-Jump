using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        MouseMovement();
    }
    void MouseMovement()
    {
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 currentPosition = transform.position;   
        currentPosition.x += mouseX;
        transform.position = currentPosition;
    }
}
