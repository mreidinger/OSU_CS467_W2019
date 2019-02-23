using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    //maybe not needed
    
    private static BagScript instance;

    public static BagScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<BagScript>();
            }

            return instance;
        }
    }
    


    [SerializeField]
    private GameObject slotPrefab;

    private CanvasGroup canvasGroup; //used to hide/show ui

    private List<SlotScript> slots = new List<SlotScript>();


    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    //makes slots for bag
    public void AddSlots(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            SlotScript slot = Instantiate(slotPrefab, transform).GetComponent<SlotScript>(); //slotprefab child of current bagscipt's transform
            slots.Add(slot);
        }
    }

    public bool AddItem(Item item)
    {
        //look for an empty slot and put item
        foreach(SlotScript slot in slots)
        {
            if (slot.IsEmpty)
            {
                slot.AddItem(item);
                Debug.Log(slots.Count);
                return true;
            }
        }
        return false;
    }

    public void OpenClose(Bag bag)
    {
        //Debug.Log("openclose called");
        canvasGroup.alpha = canvasGroup.alpha > 0 ? 0 : 1; //shown: 1, hidden: 0
        canvasGroup.blocksRaycasts = canvasGroup.blocksRaycasts == true ? false : true; //similar logic
        bag.Clicked = bag.Clicked == true ? false : true;
    }
}
