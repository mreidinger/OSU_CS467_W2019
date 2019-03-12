using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Figurine", menuName ="Items/Figurine", order =23)]
public class Figurine : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}

