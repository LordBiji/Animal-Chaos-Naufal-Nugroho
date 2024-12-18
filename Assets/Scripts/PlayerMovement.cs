using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed = 250f;

    void Start()
    {
        gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float movementX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3 (movementX * moveSpeed, 0f, 0f);
    }

}
