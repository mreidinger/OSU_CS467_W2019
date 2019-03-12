using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Chalice", menuName ="Items/Chalice", order =33)]
public class Chalice : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
