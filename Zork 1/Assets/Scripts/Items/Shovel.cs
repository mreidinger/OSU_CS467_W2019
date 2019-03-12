using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Shovel", menuName ="Items/Shovel", order =18)]
public class Shovel : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}

