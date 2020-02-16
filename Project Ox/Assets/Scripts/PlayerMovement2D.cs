using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{

    public CharacterController2D controller;

    public Joystick joystick;

    public float runSpeed = 40f;
    public float jHMove;
    public float negJHMove;
    public float jVMove;
    public float negJVMove;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        //horizontalMove = joystick.Horizontal * runSpeed;       I like this movement alot but will flesh it out before choosing

        if (joystick.Horizontal >= jHMove)
        {
            horizontalMove = runSpeed;
        }
        else if (joystick.Horizontal <= -negJHMove)
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }

        float verticalMove = joystick.Vertical;

        if (verticalMove >= jVMove)
        {
            jump = true;
        }

        if (verticalMove <= -negJVMove)
        {
            crouch = true;
        }

        else
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
