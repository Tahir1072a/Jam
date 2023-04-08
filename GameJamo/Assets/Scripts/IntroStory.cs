using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class IntroStory : MonoBehaviour
{
    public TextMeshProUGUI hosgeldin;
    public TextMeshProUGUI canavar;
    public TextMeshProUGUI hikaye;
    public TextMeshProUGUI amac;

    //public InputActionReference myButtonAction;

    private int buttonPressCount = 0;

    private void Start()
    {
        hosgeldin.text = "Akademiye ho�geldin";
        
    }
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Next();
        }
    }
    void Next()
    {
        buttonPressCount++;
        hosgeldin.text = " ";
        
        switch (buttonPressCount)
        {
            case 1:
                hikaye.text = "Hikaye";
                break;
            case 2:
                hikaye.text = " ";
                amac.text = "Kitaplar�m�z� bulmam�z gerekiyor.Bunun i�in sana ihtiyac�m�z var.�ncelikle sana zarar verecek k�t� duygular�" +
                    "yenmelisin.Her a�amada bir kitab� bulacaks�n.�� kitab� bulursan oyunu kazan�rs�n.Dikkat et canavarlar�n k�t�" +
                    "duygular�na kap�lma yoksa bulamazs�n";
                break;
            case 3:
                amac.text = " ";
                hikaye.text = " ";
                canavar.text = "Canavar";
                break;
            case 4:
                SceneManager.LoadScene(0);//buraya dikat d�zeltilmeli kodda s�k�nt� yok ama unitide bak�lmal�!!
                break;
            default:
                
                break;
        }
    }


}




