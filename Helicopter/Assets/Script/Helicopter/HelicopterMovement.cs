using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovement : MonoBehaviour
{
    enum Mode { FALL = -1, STAY, RISE };
    Mode moveMode = Mode.STAY;
    float speed = 0.0f;
    public Rigidbody HelicopterRigidbody;

    void Start()
    {
        HelicopterRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
            moveMode = Mode.RISE;
        if (Input.GetKey(KeyCode.S) == true)
            moveMode = Mode.STAY;
        if (Input.GetKey(KeyCode.X) == true)
            moveMode = Mode.FALL;

        switch (moveMode)
        {
        case Mode.FALL:
            HelicopterRigidbody.AddForce(0, -speed, 0);
            break;

        case Mode.STAY:
            break;

        case Mode.RISE:
            HelicopterRigidbody.AddForce(0, speed, 0);

            if (speed < 1.0f)
                speed += 0.001f;
            
            break;
        }
    }
}
