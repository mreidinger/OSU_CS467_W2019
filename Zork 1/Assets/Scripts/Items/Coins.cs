using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Coins", menuName ="Items/Coins", order =26)]
public class Coins : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
