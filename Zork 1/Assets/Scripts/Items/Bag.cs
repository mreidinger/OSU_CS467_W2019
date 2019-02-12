using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Bag",menuName ="Items/Bag",order =1)]
public class Bag : Item, IUseable
{
    private int slots; //slots in a bag

    private bool clicked;

    [SerializeField]
    private GameObject bagPrefab; //access the prefab

    public BagScript MyBagScript { get; set; }
    public int Slots { get => slots; }

    public Sprite MyIcon => throw new System.NotImplementedException();

    public bool Clicked { get => clicked; set => clicked = value; }

    public void Initialize(int slots)
    {
        this.slots = slots;
        //clicked = false;
    }

    //equips the current bag.
    public void Use()
    {
        if (InventoryScript.MyInstance.CanAddBag)
        {
            Remove();
            MyBagScript = Instantiate(bagPrefab, InventoryScript.MyInstance.transform).GetComponent<BagScript>(); //creates bag prefab under the inventory, also loads the associateed script.
            MyBagScript.AddSlots(slots);
            InventoryScript.MyInstance.AddBag(this);
        }
    }
}
