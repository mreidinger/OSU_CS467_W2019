using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Trident", menuName ="Items/Trident", order =5)]
public class Trident : Item, IUseable
{
    public void Use()
    {
        //look into required actions for this item.
        Remove();
    }
}
