using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{

    public CharacterController2D controller;

    public Joystick joystick;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {

        float verticalMove = joystick.Vertical;

        // Movement will allow you to walk
        horizontalMove = joystick.Horizontal * runSpeed;

        //Jumping
        if (verticalMove >= 0.7f)
        {
            jump = true;
        }

        //Crouching
        if (verticalMove <= -0.7f)
        {
            crouch = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        crouch = false;
    }
}
