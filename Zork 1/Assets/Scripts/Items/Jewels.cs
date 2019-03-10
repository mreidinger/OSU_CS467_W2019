using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Jewels", menuName ="Items/Jewels", order =31)]
public class Jewels : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
