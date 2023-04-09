using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    [Header("Animator")]
    public Animator animator;
    Vector2 moveInput;
    [Header("Fire")]
    public Transform namlu, mermi, nokta;
    Transform klonBullet;
    [SerializeField] float bulletSpeed = 100f;
    [Header("Movement")]
    public bool invert = false;
    [SerializeField] public float moveSpeed = 5f;


    PlayerInput playerInput;
    GameManager gameManager;

    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
        gameManager = FindAnyObjectByType<GameManager>();
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
        animator.SetTrigger("isFire");
        Debug.Log("Space basildi");
        klonBullet = Instantiate(mermi, nokta.position, Quaternion.identity);
        //klon.GetComponent<Rigidbody2D>().AddForce(klon.forward * 1000f);

        Rigidbody2D klonRigidbody = klonBullet.GetComponent<Rigidbody2D>();
        klonBullet.GetComponent<Rigidbody2D>().AddForce(transform.localScale.x * bulletSpeed * Vector2.one);
        //klonRigidbody.AddForce(klon.transform.right * 10f);
    }
}
