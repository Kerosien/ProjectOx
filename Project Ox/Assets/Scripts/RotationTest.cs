using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest : MonoBehaviour
{

    public Transform target;
    public float orbitDistance = 10f;
    public float orbitDegreesPerSec = 180.0f;

    // Use this for initialization
    void Start()
    {

    }

    void Orbit()
    {
        if (target != null)
        {
            // Keep us at orbitDistance from target
            transform.position = target.position + (transform.position - target.position).normalized * orbitDistance;
            transform.RotateAround(target.position, Vector3.forward, orbitDegreesPerSec * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {

        // Call from LateUpdate instead...
        // Orbit();

    }
    // Call from LateUpdate if you want to be sure your
    // target is done with it's move.
    void LateUpdate()
    {

        Orbit();

    }
}

