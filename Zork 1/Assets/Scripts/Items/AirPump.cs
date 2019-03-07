using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Airpump", menuName ="Items/Airpump", order =6)]
public class AirPump : Item, IUseable
{
    public void Use()
    {
        Remove();
    }
}
