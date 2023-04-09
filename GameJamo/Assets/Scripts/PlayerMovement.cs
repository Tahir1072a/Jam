using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    [HideInInspector]public Animator animator;
    Vector2 moveInput;
    [Header("Fire")]
    public Transform mermi, nokta;
    Transform klonBullet;
    [Header("Movement")]
    public bool invert = false;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] float bulletSpeed = 1f;

    PlayerInput playerInput;
    GameManager gameManager;
    Camera mainCamera;

    float xSpeed;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
        gameManager = FindAnyObjectByType<GameManager>();
        mainCamera = Camera.main;
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        FlipSprite();
        UpdateAnimate();
        Die();
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
    public void Die()
    {
        if(!gameManager.isDead)
        {
            return;
        }
        gameManager.isDead = false;
        animator.SetTrigger("isDead");
        playerInput.DeactivateInput();
    }
    void OnShoot()
    {
        if(gameManager.ShowBulletNum() == 0)
        {
            return;
        }
        animator.SetTrigger("isFire");
        klonBullet = Instantiate(mermi, nokta.position, Quaternion.identity);
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePosition.z = 0;
        Vector2 shootingDirection = (mousePosition - nokta.position).normalized;
        if(shootingDirection.normalized.x != transform.localScale.x)
        {
            shootingDirection.x = transform.localScale.x;
        }
        klonBullet.GetComponent<Rigidbody2D>().velocity = shootingDirection * bulletSpeed;
        gameManager.ReduceBulletNum();
    }
}
