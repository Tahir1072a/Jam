using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    Animator animator;

    bool isDead = false;

    [SerializeField] public EnemySO enemySO;

    Rigidbody2D rbEnemy;
    Vector2 diff;

    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void FixedUpdate()
    {
        if (!isDead)
        {
            calculateMovement();
            moveEnemy(diff);
            flipSprite(diff);
        }
    }

    Vector2 calculateDifference(Transform p)
    {
        return p.position - this.transform.position;
    }

    void calculateMovement()
    {
        diff = calculateDifference(player.transform);

        diff.Normalize();
    }

    void moveEnemy(Vector2 direction)
    {
        rbEnemy.velocity = direction * enemySO.speed;
    }

    void flipSprite(Vector2 dir)
    {
        transform.localScale = new Vector2(Mathf.Sign(dir.x), transform.localScale.y);
    }

    public void enemyDead()
    {
        isDead = true;
        animator.SetBool("isDead", true);
        Destroy(gameObject, enemySO.deathSpeed);
    }

}
