using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.InputSystem.HID.HID;

public class IntroScript : MonoBehaviour
{
    public TextMeshProUGUI mainText;

    public Button button; 
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
                
                mainText.text = 
                    "Ho? geldin! Akademi boyunca motivasyonunu etkileyen zorluklar ya??yor musun? Cevab?n evetse, bu oyunda sana ihtiyac?m?z var. Biliyoruz, k?t? duygular senin motivasyonunu etkiliyor ve ba?ar?na engel oluyor. ";
                break;
            case 2:
                mainText.text = 
                    "Oyunda seni zorlu bir yolculuk bekliyor. Yapman gereken, sana zarar vermek i?in etrafta dola?an bu k?t? duygularla sava?mak ve motivasyonunu y?ksek tutarak Akademi'deki ?? kitab? bulmak!";
                break;
            case 3:
                mainText.text = 
                    "Ba?ar?l? olmak i?in cesaretin ve g??l? bir motivasyonun olmas? gerekiyor. Unutma, her ba?ar? seni daha da g??l? k?lacak ve motivasyonunu art?racak. Sen de bu zorlu m?cadeleyi kazanmak i?in haz?rsan, haydi ba?layal?m!";
                break;
            case 4:
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }


    }
}
