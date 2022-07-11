using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    bool isHelicopterMove;
    float rotSpeed = 50.0f;

    void Start()
    {
        isHelicopterMove = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
            isHelicopterMove = true;
        
        if (isHelicopterMove)
        {
            // if (rotSpeed < 100.0f)
            // {
            //     rotSpeed += 10.0f;
            // }

            transform.Rotate(new Vector3(0, rotSpeed, 0));
        }
    }
}
