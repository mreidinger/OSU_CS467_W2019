using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Sack",menuName ="Items/Sack",order =11)]
public class Sack : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
