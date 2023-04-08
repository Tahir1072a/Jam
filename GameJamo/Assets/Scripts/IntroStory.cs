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
        hosgeldin.text = "Akademiye hoþgeldin";
        
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
                amac.text = "Kitaplarýmýzý bulmamýz gerekiyor.Bunun için sana ihtiyacýmýz var.Öncelikle sana zarar verecek kötü duygularý" +
                    "yenmelisin.Her aþamada bir kitabý bulacaksýn.Üç kitabý bulursan oyunu kazanýrsýn.Dikkat et canavarlarýn kötü" +
                    "duygularýna kapýlma yoksa bulamazsýn";
                break;
            case 3:
                amac.text = " ";
                hikaye.text = " ";
                canavar.text = "Canavar";
                break;
            case 4:
                SceneManager.LoadScene(0);//buraya dikat düzeltilmeli kodda sýkýntý yok ama unitide bakýlmalý!!
                break;
            default:
                
                break;
        }
    }


}




