using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Coal", menuName ="Items/Coal", order =22)]
public class Coal : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}

