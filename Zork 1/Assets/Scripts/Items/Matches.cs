using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Matches", menuName ="Items/Matches", order =28)]
public class Matches : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
