using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    [SerializeField] float moveSpeed = 3f;

    Rigidbody2D rbEnemy;
    Vector2 diff;

    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        calculateMovement();
        moveEnemy(diff);
    }

    Vector2 calculateDifference(Transform p)
    {
        return p.position - this.transform.position;
    }

    void calculateMovement()
    {
        diff = calculateDifference(player.transform);

        rbEnemy.rotation = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

        diff.Normalize();
    }

    void moveEnemy(Vector2 direction)
    {
        rbEnemy.MovePosition((Vector2)this.transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
