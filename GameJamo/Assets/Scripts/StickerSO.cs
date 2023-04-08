using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Sticker",menuName ="StickerSO")]
public class StickerSO : ScriptableObject
{
    //karakterin toplayabilece�i ve ald��� negatif etkileri tersine �eviren object tipleri.
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
