using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovement : MonoBehaviour
{
    //public GameObject Propeller;
    enum Mode { FALL = -1, STAY, RISE };
    Mode moveMode = Mode.STAY;
    public float speed = 0.001f;
    public Rigidbody HelicopterRigidbody;

    void Start()
    {
        HelicopterRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 키에 따른 모드 - 상승 / 유지 / 하강
        if (Input.GetKey(KeyCode.W) == true)
            moveMode = Mode.RISE;
        if (Input.GetKey(KeyCode.S) == true)
            moveMode = Mode.STAY;
        if (Input.GetKey(KeyCode.X) == true)
            moveMode = Mode.FALL;

        switch (moveMode)
        {
        case Mode.FALL:
            if (speed > 0.5f)
                speed -= 0.001f;
            
            HelicopterRigidbody.AddForce(0, -speed, 0);
            break;

        case Mode.STAY:
            break;

        case Mode.RISE:
            HelicopterRigidbody.AddForce(0, speed, 0);

            if (speed < 3.0f)
                speed += 0.001f;
            else 
                moveMode = Mode.FALL;
            
            break;
        }
    }
}
