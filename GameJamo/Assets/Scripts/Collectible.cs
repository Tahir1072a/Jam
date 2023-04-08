using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible: MonoBehaviour
{
    public int sayfa;
    public int bomba;
    public int mermi;
    public int xp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sticker")
        {
            xp += 10;
            Debug.Log(xp);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Sayfa")
        {
            sayfa += 1;
            Debug.Log(sayfa);
            Time.timeScale = 0;
            Debug.Log("Bölüm bitti");
            //SceneManager.LoadScene(1);
            Debug.Log("Diðer sahneye geçti");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Mermi")
        {
            mermi += 1;
            Debug.Log(mermi);            
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bomba")
        {
            xp += 10;
            Debug.Log(xp);
            Destroy(collision.gameObject);
        }
    }
}
