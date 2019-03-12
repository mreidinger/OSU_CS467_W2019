using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Screwdriver", menuName ="Items/Screwdriver", order =30)]
public class Screwdriver : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
