using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Bar", menuName ="Items/Bar", order =7)]
public class PlatinumBar : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
