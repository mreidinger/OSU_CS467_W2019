using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Candle", menuName ="Items/Candle", order =14)]
public class Candle : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
