using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    public HingeJoint2D hinge;
    JointMotor2D motor;
    float motorSpeed = 0f;

    void Start()
    {
        motor = hinge.motor;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            motorSpeed -= (1f + ((float)ScoreKeeper.score / 2f));
        } 
        else if (Input.GetMouseButton(1))
        {
            motorSpeed += (1f + ((float)ScoreKeeper.score / 2f));
        } 
        else
        {
            motorSpeed = motorSpeed > 0 ? motorSpeed -= 0.2f: motorSpeed += 0.2f;
        }
        motorSpeed = Mathf.Clamp(motorSpeed, -100f, 100f);
        motor.motorSpeed = motorSpeed;
        hinge.motor = motor;
    }

}
