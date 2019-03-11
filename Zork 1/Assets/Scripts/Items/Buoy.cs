using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Buoy", menuName ="Items/Buoy", order =17)]
public class Buoy : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
