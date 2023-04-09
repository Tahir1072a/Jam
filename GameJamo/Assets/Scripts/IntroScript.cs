using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour
{
    public TextMeshProUGUI mainText;
    [SerializeField] TextMeshProUGUI buttonText;

    private int basmaSayisi = 0;
    SoundSource soundSource;
    private void Awake()
    {
        soundSource = FindFirstObjectByType<SoundSource>();
    }
    private void Start()
    {
        soundSource.PlayMainMusic(MusicSO.AuidioTypes.MainStoryMusic);
        Debug.Log(soundSource);
    }
    public void OnClick()
    {
        Next();
        soundSource.PlayPlayerMusic(MusicSO.AuidioTypes.ButtonClickSound);
    }
    public void OnClickReStart()
    {
        SceneManager.LoadScene(0);
        soundSource.PlayPlayerMusic(MusicSO.AuidioTypes.ButtonClickSound);
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
                buttonText.text = "Start";
                break;
            case 4:
                SceneManager.LoadScene(1);
                break;
            default:
                break;
        }


    }
}
