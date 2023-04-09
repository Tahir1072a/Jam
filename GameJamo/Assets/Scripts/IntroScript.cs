using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    public TextMeshProUGUI mainText;
    public PlayerInput playerInput;
    
    private int basmaSayisi = 0;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Next();
        }
    }

    void Next()
    {
        basmaSayisi++;
        

        switch (basmaSayisi)
        {
            case 1:
                
                mainText.text = "Hikaye" +
                    "Kitaplarýmýzý bulmamýz gerekiyor.Bunun için sana ihtiyacýmýz var.Öncelikle sana zarar verecek kötü duygularý" +
                     "yenmelisin.Her aþamada bir kitabý bulacaksýn.Üç kitabý bulursan oyunu kazanýrsýn.Dikkat et canavarlarýn kötü" +
                     "duygularýna kapýlma yoksa bulamazsýn";
                break;
            case 2:
                mainText.text = "Oynanýþ" +
                    "Kitaplarýmýzý bulmamýz gerekiyor.Bunun için sana ihtiyacýmýz var.Öncelikle sana zarar verecek kötü duygularý" +
                     "yenmelisin.Her aþamada bir kitabý bulacaksýn.Üç kitabý bulursan oyunu kazanýrsýn.Dikkat et canavarlarýn kötü" +
                     "duygularýna kapýlma yoksa bulamazsýn";
                break;
            case 3:
                mainText.text = "Canavar" +
                    "Kitaplarýmýzý bulmamýz gerekiyor.Bunun için sana ihtiyacýmýz var.Öncelikle sana zarar verecek kötü duygularý" +
                     "yenmelisin.Her aþamada bir kitabý bulacaksýn.Üç kitabý bulursan oyunu kazanýrsýn.Dikkat et canavarlarýn kötü" +
                     "duygularýna kapýlma yoksa bulamazsýn";
                break;
            case 4:
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }


    }
}
