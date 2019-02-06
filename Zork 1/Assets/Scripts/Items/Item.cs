using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    [SerializeField]
    private Sprite icon; //all children of this superclass must have an icon

    [SerializeField]
    private int stacksize; //if items can be stacked

    private SlotScript slot;

    public Sprite MyIcon
    {
        get => icon;
    }
    public int Stacksize
    {
        get => stacksize;
    }
    public SlotScript MySlot 
    {
        get => slot;
        set => slot = value;
    }

    public void Remove()
    {
        if (MySlot != null)
        {
            MySlot.RemoveItem(this);
        }
    }
}
