using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Enemy",menuName ="EnemySO")]
public class EnemySO : ScriptableObject
{
    public enum EnemyTypes
    {
        Deli,
        Sinirli,
        Yorgun,
        Depresif,
        Mutsuz,
        Uykulu
    }

    [SerializeField] public float speed;

    [SerializeField] public EnemyTypes enemyType;
}
