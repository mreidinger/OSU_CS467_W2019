using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Sceptre", menuName ="Items/Sceptre", order =35)]
public class Sceptre : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
