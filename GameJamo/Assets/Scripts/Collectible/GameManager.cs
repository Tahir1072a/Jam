using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Oyuncu Çantasý")]
    [SerializeField] short pageNum;
    [SerializeField] short bulletNum;
    [SerializeField] short bombaNum;
    [Header("UI")]
    [SerializeField] TextMeshProUGUI pageText;
    [SerializeField] TextMeshProUGUI bulletText;
    [SerializeField] TextMeshProUGUI bombaText;
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
        UpdateBulletView();
        UpdateBombaView();
    }
    private void UpdatePageView()
    {
        pageText.text = pageNum.ToString();
    }
    public void UpdateBulletView()
    {
        bulletText.text = bulletNum.ToString();
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
    public void IncreaseBulletNum()
    {
        bulletNum++;
        UpdateBulletView();
    }
    public void IncreaseBombaNum()
    {
        bombaNum++;
        UpdateBombaView();
    }
}
