using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Garlic", menuName ="Items/Garlic", order =34)]
public class Garlic : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
