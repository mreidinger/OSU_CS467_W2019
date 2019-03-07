using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Scarab", menuName ="Items/Scarab", order =19)]
public class Scarab : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}

