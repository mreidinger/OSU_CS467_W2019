using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField]
    private Sprite icon; //all children of this superclass must have an icon

    [SerializeField]
    private int stacksize; //if items can be stacked

    public Sprite Icon
    {
        get => icon;
    }
    public int Stacksize
    {
        get => stacksize;
    }
}
