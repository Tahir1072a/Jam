using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour
{
    public TextMeshProUGUI mainText;
    [SerializeField] TextMeshProUGUI buttonText;

    private int basmaSayisi = 0;

    public void OnClick()
    {
        Next();
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
                buttonText.text = "Start";
                break;
            case 4:
                SceneManager.LoadScene(2);
                break;
            default:
                break;
        }


    }
}
