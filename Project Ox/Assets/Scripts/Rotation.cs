using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float moveSpeed = 600;

    float movement = 0f;

    public Vector3 target = new Vector3(5.0f, 0.0f, 0.0f);

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {

    
        transform.RotateAround(target, Vector3.forward, movement * Time.deltaTime * -moveSpeed);
    }

}