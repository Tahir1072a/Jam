using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Stick1er : ScriptableObject
{
    public enum StickerType
    {
        AntiSinir,
        AntiStress,
        AntiTired,
        AntiSadness,
        AntiDepresif
    }

    [SerializeField] StickerType stickerType;

}
