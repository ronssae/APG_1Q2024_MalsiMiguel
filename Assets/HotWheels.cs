using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotWheels : MonoBehaviour
{
    private WheelJoint2D hotWheels;
    private JointMotor2D coldWheels;

    // Start is called before the first frame update
    void Start()
    {
        hotWheels = GetComponent<WheelJoint2D>();
        coldWheels.maxMotorTorque = 100000f;
    }

    // Update is called once per frame
    void Update()
    {
        hotWheels.motor = coldWheels;

        if (Input.GetKey(KeyCode.W))
        {
            coldWheels.motorSpeed += 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            coldWheels.motorSpeed -= 1f;
        }

    }
}
