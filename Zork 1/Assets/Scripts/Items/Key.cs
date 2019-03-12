using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Key", menuName ="Items/Key", order =27)]
public class Key : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
