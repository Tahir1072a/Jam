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
                    "Kitaplar�m�z� bulmam�z gerekiyor.Bunun i�in sana ihtiyac�m�z var.�ncelikle sana zarar verecek k�t� duygular�" +
                     "yenmelisin.Her a�amada bir kitab� bulacaks�n.�� kitab� bulursan oyunu kazan�rs�n.Dikkat et canavarlar�n k�t�" +
                     "duygular�na kap�lma yoksa bulamazs�n";
                break;
            case 2:
                mainText.text = "Oynan��" +
                    "Kitaplar�m�z� bulmam�z gerekiyor.Bunun i�in sana ihtiyac�m�z var.�ncelikle sana zarar verecek k�t� duygular�" +
                     "yenmelisin.Her a�amada bir kitab� bulacaks�n.�� kitab� bulursan oyunu kazan�rs�n.Dikkat et canavarlar�n k�t�" +
                     "duygular�na kap�lma yoksa bulamazs�n";
                break;
            case 3:
                mainText.text = "Canavar" +
                    "Kitaplar�m�z� bulmam�z gerekiyor.Bunun i�in sana ihtiyac�m�z var.�ncelikle sana zarar verecek k�t� duygular�" +
                     "yenmelisin.Her a�amada bir kitab� bulacaks�n.�� kitab� bulursan oyunu kazan�rs�n.Dikkat et canavarlar�n k�t�" +
                     "duygular�na kap�lma yoksa bulamazs�n";
                break;
            case 4:
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }


    }
}
