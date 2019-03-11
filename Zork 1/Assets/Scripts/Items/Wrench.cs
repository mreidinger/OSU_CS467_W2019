using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Wrench", menuName ="Items/Wrench", order =29)]
public class Wrench : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
