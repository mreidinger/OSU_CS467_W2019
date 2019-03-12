using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Bracelet", menuName ="Items/Bracelet", order =21)]
public class Bracelet : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
