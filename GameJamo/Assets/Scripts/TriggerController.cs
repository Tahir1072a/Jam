using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
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
            Destroy(collision.gameObject);
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Deli)
        {
            energy -= 10;
            // Deli karakterin yön tuşlarını tersine çevirir
            playerMovement.invert = true;
            Destroy(collision.gameObject);
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Uykulu)
        {
            energy -= 10;
            // Uykulu karakterin hızını yarıya düşürür
            playerMovement.moveSpeed /= 2f;
            Destroy(collision.gameObject);
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Depresif)
        {
            energy -= 50;
            Debug.Log("Enerjiyi yariya dusurur / 50 puan duser");
            Destroy(collision.gameObject);
        }
        if (enemyScript.enemySO.enemyType == EnemySO.EnemyTypes.Mutsuz)
        {
            energy -= 10;
            Debug.Log("Ates etme hizi dusecek");
            Destroy(collision.gameObject);
        }
    }
}
