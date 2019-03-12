using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Rope", menuName ="Items/Rope", order =9)]
public class Rope : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
