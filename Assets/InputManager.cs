using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    public GameObject player;

    private Rigidbody rb;
    private Vector2 movement = new Vector2 (0,0);
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movement.x = movementVector.x;
        movement.y = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector2 movementPlayer = new Vector2(movement.x, movement.y);
        rb.AddForce(movement * speed);
    }
}
