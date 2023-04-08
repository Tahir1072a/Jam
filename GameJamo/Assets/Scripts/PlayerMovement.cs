using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Vector2 moveInput;

    public bool invert = false;

    [SerializeField] public float moveSpeed = 5f;


    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        Move();
    }
    
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }


    void Move()
    {
        if (invert)
        {
            rbPlayer.velocity = new Vector2(moveInput.x * moveSpeed * -1f, moveInput.y * moveSpeed * -1f);
        }
        else
        {
            rbPlayer.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
        }
    }
}
