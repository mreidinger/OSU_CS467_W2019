using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Coffin", menuName ="Items/Coffin", order =32)]
public class Coffin : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
