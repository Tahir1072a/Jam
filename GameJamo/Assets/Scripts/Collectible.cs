using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible: MonoBehaviour
{
    //public int sayfa;
    //public int bomba;
    //public int mermi;
    //public int xp;

    //[SerializeField] Collider2D playerCollider;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (playerCollider.IsTouchingLayers(LayerMask.GetMask("Stickers")))
    //    {
    //        xp += 10;
    //        Debug.Log(xp);
    //        Destroy(collision.gameObject);
    //    }
    //    if (playerCollider.IsTouchingLayers(LayerMask.GetMask("Pages")))
    //    {
    //        sayfa += 1;
    //        Debug.Log(sayfa);
    //        Time.timeScale = 0;
    //        Debug.Log("Bölüm bitti");
    //        //SceneManager.LoadScene(1);
    //        Debug.Log("Diðer sahneye geçti");
    //        Destroy(collision.gameObject);
    //    }
    //    //if (playerCollider.IsTouchingLayers(LayerMask.GetMask("Bullets")))
    //    //{
    //    //    mermi += 1;
    //    //    Debug.Log(mermi);            
    //    //    Destroy(collision.gameObject);
    //    //}
    //    if (collision.gameObject.tag == "Bomba")
    //    {
    //        xp += 10;
    //        Debug.Log(xp);
    //        Destroy(collision.gameObject);
    //    }
    //}
}
