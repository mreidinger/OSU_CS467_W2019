using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName  ="leaflet",menuName ="Items/Leaflet", order =1)]
public class Leaflet : Item, IUseable
{
    public void Use()
    {
        Remove();
        //code to read leaflet
        //can also ask player if they wish to drop it.
    }
}
