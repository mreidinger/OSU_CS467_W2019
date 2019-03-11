using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PotOfGold", menuName ="Items/PotOfGold", order =20)]
public class PotOfGold : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
