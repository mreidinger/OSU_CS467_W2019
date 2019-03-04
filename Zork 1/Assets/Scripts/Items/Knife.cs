using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Knife", menuName ="Items/Knife", order =8)]
public class Knife : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
