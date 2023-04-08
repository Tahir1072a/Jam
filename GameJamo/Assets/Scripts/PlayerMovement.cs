using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Vector2 moveInput;

    [SerializeField] float moveSpeed = 5f;


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
        rbPlayer.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
    }
}
