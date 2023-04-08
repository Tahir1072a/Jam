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

        switch (enemyScript.enemySO.enemyType)
        {
            case EnemySO.EnemyTypes.Sinirli:
                energy -= 10;
                Debug.Log("Ekran sallama kodu");
                break;

            case EnemySO.EnemyTypes.Deli:
                energy -= 10;
                // Deli karakterin yön tuşlarını tersine çevirir
                playerMovement.invert = true;
                break;

            case EnemySO.EnemyTypes.Uykulu:
                energy -= 10;
                // Uykulu karakterin hızını yarıya düşürür
                playerMovement.moveSpeed /= 2f;
                break;

            case EnemySO.EnemyTypes.Depresif:
                energy -= 50;
                Debug.Log("Enerjiyi yariya dusurur / 50 puan duser");
                break;

            case EnemySO.EnemyTypes.Mutsuz:
                energy -= 10;
                Debug.Log("Ates etme hizi dusecek");
                break;
        }
    }
}
