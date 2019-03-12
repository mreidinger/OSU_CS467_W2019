using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Bottle", menuName ="Items/Bottle", order =13)]
public class Bottle : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
