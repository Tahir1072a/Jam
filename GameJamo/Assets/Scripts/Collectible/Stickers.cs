using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickers : MonoBehaviour
{
    [SerializeField] StickerSO stickerSO;
    Collider2D collider2D;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collider2D.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Destroy(gameObject);
        }
    }
}
