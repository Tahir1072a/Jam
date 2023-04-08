using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    [SerializeField] public EnemySO enemySO;

    Rigidbody2D rbEnemy;
    Vector2 diff;

    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
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
        rbEnemy.MovePosition((Vector2)this.transform.position + (direction * enemySO.speed * Time.deltaTime));
    }
}
