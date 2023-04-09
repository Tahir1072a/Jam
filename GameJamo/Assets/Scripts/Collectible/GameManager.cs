using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static MusicSO;

public class GameManager : MonoBehaviour
{
    [Header("Oyuncu �antas�")]
    [SerializeField] short pageNum;
    [SerializeField] short bombaNum;
    [Header("UI")]
    [SerializeField] TextMeshProUGUI pageText;
    [SerializeField] TextMeshProUGUI bombaText;
    [SerializeField] Image enerygBar;
    [SerializeField] Image reloadImage;
    [Header("AudioSources")]
    [SerializeField] AudioSource mainMusicSource;
    [SerializeField] AudioSource playerMusicSource;
    [SerializeField] MusicSO musics;

    [SerializeField] float amountOfDamage = 0.1f;
    public bool isDead = false;
    void Awake()
    {
        if (FindObjectsOfType<GameManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        UpdatePageView();
        UpdateBombaView();
    }
    public void ReduceEnergy()
    {
        enerygBar.fillAmount -= amountOfDamage;
        if (enerygBar.fillAmount <= 0)
        {
            isDead = true;
        }
    }
    public void ReduceEnergy(float amountDamage)
    {
        enerygBar.fillAmount -= amountDamage;
        if(enerygBar.fillAmount <= 0)
        {
            isDead = true;
        }
    }
    public void IncreaseEnergy(float amountOfHeal)
    {
        if(enerygBar.fillAmount == 1)
        {
            return;
        }
        enerygBar.fillAmount += amountOfHeal;
    }
    private void UpdatePageView()
    {
        pageText.text = pageNum.ToString();
    }
    public void UpdateBombaView()
    {
        bombaText.text = bombaNum.ToString();
    }
    public void IncreasePageNum()
    {
        pageNum++;
        UpdatePageView();
    }
    public void IncreaseBombaNum()
    {
        bombaNum++;
        UpdateBombaView();
    }
    public void ReduceBombNum()
    {
        bombaNum--;
        UpdateBombaView();
    }
    public short ShowPageNum()
    {
        return pageNum;
    }
    public short ShowBombNum()
    {
        return bombaNum;
    }
    public void PlayPlayerMusic(MusicSO.AuidioTypes auidioType)
    {
       // playerMusicSource.PlayOneShot(musics.audioClips.FirstOrDefault(p => p.type == auidioType).audioClips);
    }
    public void PlayMainMusic(MusicSO.AuidioTypes audioType)
    {
       // mainMusicSource.PlayOneShot(musics.audioClips.FirstOrDefault(p => p.type == audioType).audioClips);
    }
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(2);
    }
    public void UpdateViewReloadImage(float delayTime,float timerMultiplier)
    {
        reloadImage.fillAmount += (1 / delayTime) * Time.deltaTime * timerMultiplier;
    }
    public void UpdateViewReloadImage()
    {
        reloadImage.fillAmount = 0;
    }
}
