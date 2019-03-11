using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Lantern", menuName ="Items/Lantern", order =12)]
public class Lantern : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}

