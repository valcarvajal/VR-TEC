using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 5;

    void Start()
    {
        rb = GetComponent <Rigidbody>();
    }

    void Update()
    {
        // V = speed * direction
        // could be rb.velocity = speed * transformforward;
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.X)) {
            // Jump
            rb.velocity = new Vector3(0, 5, 0);
        }

        if (Input.GetKey(KeyCode.Y)) {
                    // Sprint
                    rb.velocity *= 5.0f;
        }
    }
}
