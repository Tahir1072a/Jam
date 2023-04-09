using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField] Image enerygBar;

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
        UpdateBulletView();
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
    public void ReduceBulletNum()
    {
        bulletNum--;
        UpdateBulletView();
    }
    public void ReduceBombNum()
    {
        bombaNum--;
        UpdateBombaView();
    }
    public short ShowBulletNum()
    {
        return bulletNum;
    }
    public short ShowPageNum()
    {
        return pageNum;
    }
    public short ShowBombNum()
    {
        return bombaNum;
    }
}
