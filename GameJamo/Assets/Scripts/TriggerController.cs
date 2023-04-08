using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    PlayerMovement playerMovement;
    GameManager gameManager;
    public int energy;

    void Start() 
    {
        playerMovement = GetComponent<PlayerMovement>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
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
            playerMovement.animator.SetTrigger("isHurt");
            gameManager.ReduceEnergy();
        }

        else if (collision.tag == "Sticker")
        {
            Sticker stickerScript = collision.GetComponent<Sticker>();

            switch (stickerScript.stickerSO.elixirType)
            {
                case StickerSO.ElixirTypes.AntiSinir:
                    Debug.Log("Ekran düzelme kodu");
                    break;

                case StickerSO.ElixirTypes.AntiStress:
                    // AntiStress karakterin yön tuşlarını normale çevirir
                    playerMovement.invert = false;
                    break;

                case StickerSO.ElixirTypes.AntiTired:
                    // Uykulu karakterin hızını normale çevirir
                    playerMovement.moveSpeed *= 2f;
                    break;

                case StickerSO.ElixirTypes.AntiDepresif:
                    energy += 50;
                    Debug.Log("Enerjiyi iki katina cikarir / 50 puan artar");
                    break;

                case StickerSO.ElixirTypes.AntiSadness:
                    Debug.Log("Ates etme hizi normale donecek");
                    break;
            }
        }

        Destroy(collision.gameObject);
    }
}
