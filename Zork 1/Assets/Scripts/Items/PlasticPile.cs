using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlasticPile", menuName ="Items/PlasticPile", order =16)]
public class PlasticPile : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
