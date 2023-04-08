using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickers : MonoBehaviour
{
    [SerializeField] StickerSO stickerSO;
    Collider2D collider2d;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collider2d.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Destroy(gameObject);
        }
    }
}
