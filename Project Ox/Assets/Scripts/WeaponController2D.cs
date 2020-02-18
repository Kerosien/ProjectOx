using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController2D : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public Joystick Joystick;
    private float moveSpeed = 600;
    public float movement;
    public GameObject player;
    

    private void Update()
    {

        //Rotation of the Gun
        if (Joystick.Horizontal >= .5f)
        {
            transform.RotateAround(player.transform.position, Vector3.forward, movement * Time.deltaTime * -moveSpeed);
        }
        else if (Joystick.Horizontal <= -.5f)
        {
            transform.RotateAround(player.transform.position, Vector3.back, movement * Time.deltaTime * -moveSpeed);
        }

        //Shooing of the gun
        if (Joystick.Vertical >= .5f)
        {
            Shoot();
        }
        else if (Joystick.Vertical <= -.5f)
        {
            Shoot();
        }


        //Spawn in the bullet....Might be able to add the spawn delay in here
        void Shoot ()
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
