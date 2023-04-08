using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletableBullet : MonoBehaviour
{
    Collider2D collider2D;

    private void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collider2D.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            FindObjectOfType<GameManager>().IncreaseBulletNum();
        }
    }
}
