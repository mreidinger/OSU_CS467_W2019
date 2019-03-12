using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Diamond", menuName ="Items/Diamond", order =24)]
public class Diamond : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
