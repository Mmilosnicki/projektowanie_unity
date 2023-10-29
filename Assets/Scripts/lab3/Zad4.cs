using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad4 : MonoBehaviour
{
    public float speed = 20.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(horizontalInput, 0, verticalInput);
        velocity = velocity.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + velocity);
    }
}
