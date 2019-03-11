using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Skull", menuName ="Items/Skull", order =10)]
public class Skull : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
