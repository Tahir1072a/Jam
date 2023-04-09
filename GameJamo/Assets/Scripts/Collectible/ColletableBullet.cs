using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletableBullet : MonoBehaviour
{
    Collider2D collider2d;

    private void Start()
    {
        collider2d = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collider2d.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            FindObjectOfType<GameManager>().IncreaseBulletNum();
            FindObjectOfType<GameManager>().PlayPlayerMusic(MusicSO.AuidioTypes.BUlletCollectSound);
            Destroy(gameObject);
        }
    }
}
