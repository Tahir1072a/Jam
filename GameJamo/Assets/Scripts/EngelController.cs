using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelController : MonoBehaviour
{
    PlayerMovement playerMovement;
    public int energy;

    void Start() 
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemyScript = collision.GetComponent<Enemy>();

        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Sinirli)
        {
            energy -= 10;
            Debug.Log("Ekran sallama kodu");
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Deli)
        {
            energy -= 10;
            // Deli karakterin yön tuşlarını tersine çevirir
            playerMovement.invert = true;
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Uykulu)
        {
            energy -= 10;
            // Uykulu karakterin hızını yarıya düşürür
            playerMovement.moveSpeed /= 2f;
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Depresif)
        {
            energy -= 50;
            Debug.Log("Enerjiyi yariya dusurur / 50 puan duser");
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Mutsuz)
        {
            energy -= 10;
            Debug.Log("Ates etme hizi dusecek");
        }
    }
}
