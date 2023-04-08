using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelController : MonoBehaviour
{
    public Transform nesne;
    public int enerji;

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
        if (collision.gameObject.tag == "Sinirli")
        {
            enerji = enerji - 10;
            Debug.Log("Ekran sallama kodu");
        }
        if (collision.gameObject.tag == "Deli")
        {
            enerji = enerji - 10;
            Debug.Log("Ters yönde hareket kodu");
        }
        if (collision.gameObject.tag == "Uykulu")
        {
            enerji = enerji - 10;
            Debug.Log("Karakterin hýzýný yarýya düþürme ve enerji 10 puan düþer ");
        }
        if (collision.gameObject.tag == "Depresif")
        {
            enerji = enerji - 10;
            Debug.Log("Ters yönde hareket kodu");
        }
        if (collision.gameObject.tag == "Mutsuz")
        {
            enerji = enerji - 10;
            Debug.Log("Ateþ etme hýzý düþecek");
        }
    }
}
