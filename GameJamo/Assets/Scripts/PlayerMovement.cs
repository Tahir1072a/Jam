using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    public Animator animator;
    Vector2 moveInput;

    public bool invert = false;

    [SerializeField] public float moveSpeed = 5f;


    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        FlipSprite();
        UpdateAnimate();
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

    void UpdateAnimate()
    {
        if(Mathf.Abs(moveInput.x) > Mathf.Epsilon || Mathf.Abs(moveInput.y) > Mathf.Epsilon)
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
    }
    /// <summary>
    /// Flip Spirte
    /// </summary>
    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(moveInput.x) > Mathf.Epsilon;

        if(playerHasHorizontalSpeed)
        {
            if (invert)
            {
                transform.localScale = new Vector2(-Mathf.Sign(moveInput.x), transform.localScale.y);
            }
            else
            {
                transform.localScale = new Vector2(Mathf.Sign(moveInput.x), transform.localScale.y);
            }
        }
    }
}
