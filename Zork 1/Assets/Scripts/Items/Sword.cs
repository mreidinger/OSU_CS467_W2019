using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Sword", menuName ="Items/Sword", order =4)]
public class Sword : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
