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
    public Transform swap;
  
    public GameObject baslikImage;
    public GameObject yaziHikaye;
    public GameObject yaziAmac;
    public GameObject yaziCanavar;

    private int buttonPressCount = 0;

    private void Start()
    {
        //yaziTum = GameObject.Find("YaziTum");
        //Debug.Log("yaziTum: " + yaziTum); //yaziTum null m� diye kontrol ediyoruz.
        //baslikImage = GameObject.Find("BaslikImage");
        //Debug.Log("baslikImage: " + baslikImage);
        //yaziHikaye = GameObject.Find("YaziHikaye");
        //Debug.Log("yaziHikaye: " + yaziHikaye);
        //yaziAmac = GameObject.Find("YaziAmac");
        //Debug.Log("yaziAmac: " + yaziAmac);
        //yaziCanavar = GameObject.Find("YaziCanavar");
        //Debug.Log("yaziCanavar: " + yaziCanavar);
         //swap = GameObject.Find("Swap").transform;


        //Instantiate(baslikImage, swap.position, swap.rotation);
        //hosgeldin.text = "Akademiye ho�geldin";

        //amac.text = " ";
        //hikaye.text = " ";
        //canavar.text = " ";
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
        DestroyImmediate(baslikImage, true);

        switch (buttonPressCount)
        {
            case 1:
                Instantiate(yaziHikaye, swap.position, swap.rotation);
                hikaye.text = "Hikaye";
                break;
            case 2:
                DestroyImmediate(yaziHikaye, true);
                Instantiate(yaziAmac, swap.position, swap.rotation);
                hikaye.text = " ";
                amac.text = "Kitaplar�m�z� bulmam�z gerekiyor.Bunun i�in sana ihtiyac�m�z var.�ncelikle sana zarar verecek k�t� duygular�" +
                    "yenmelisin.Her a�amada bir kitab� bulacaks�n.�� kitab� bulursan oyunu kazan�rs�n.Dikkat et canavarlar�n k�t�" +
                    "duygular�na kap�lma yoksa bulamazs�n";
                break;
            case 3:
                DestroyImmediate(yaziAmac, true);
                Instantiate(yaziCanavar, swap.position, swap.rotation);
                amac.text = " ";
                hikaye.text = " ";
                canavar.text = "Canavar";
                break;
            case 4:
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }


    }
}
