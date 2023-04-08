using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Sticker",menuName ="StickerSO")]
public class StickerSO : ScriptableObject
{
    //karakterin toplayabileceði ve aldýðý negatif etkileri tersine çeviren object tipleri.
    public enum ElixirTypes
    {
        AntiDepresif,
        AnsiSinir,
        AntiStress,
        AntiSadness,
        AntiTired
    }

    public ElixirTypes elixirType;
}
