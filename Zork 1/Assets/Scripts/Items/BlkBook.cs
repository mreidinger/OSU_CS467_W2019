using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="BlackBook", menuName ="Items/BlackBook", order =15)]
public class BlkBook: Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}

