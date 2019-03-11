using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Torch", menuName ="Items/Torch", order =25)]
public class Torch : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
