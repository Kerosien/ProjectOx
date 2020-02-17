using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController2D : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public Joystick Joystick;


    private void Update()
    {
        if (Joystick.Horizontal >= .2f)
        {
            Shoot();
        }
        else if (Joystick.Horizontal <= -.2f)
        {
            Shoot();
        }
        if (Joystick.Vertical >= .2f)
        {
            Shoot();
        }
        else if (Joystick.Vertical <= -.2f)
        {
            Shoot();
        }


        void Shoot ()
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
