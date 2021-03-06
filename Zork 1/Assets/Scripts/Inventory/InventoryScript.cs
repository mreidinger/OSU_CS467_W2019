﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    private static InventoryScript instance;

    public static InventoryScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<InventoryScript>();
            }

            return instance;
        }
    }
    [SerializeField]
    private List<Bag> bags = new List<Bag>();

    [SerializeField]
    private BagButton[] bagButtons;

    //debugging purposes
    public Item[] items;

    public bool CanAddBag
    {
        get { return bags.Count < 1; }
    }

    private void Awake()
    {
        Bag bag = (Bag)Instantiate(items[0]);
        bag.Initialize(16);
        bag.Use();
        bag.Clicked = false;
        //call once to hide initialized bag
        bag.MyBagScript.OpenClose(bag);
    }
    //debug
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            //could I call this on collision?
            /*
            Bag bag = (Bag)Instantiate(items[0]);
            bag.Initialize(16);
            bag.Use();*/
            Leaflet leaflet = (Leaflet)Instantiate(items[1]);
            AddItem(leaflet);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Bag bag = (Bag)Instantiate(items[0]);
            //print(bag);
            bag.Initialize(16);
            AddItem(bag);
        }
    }
    //end debuggging

    public void AddItem(Item item)
    {
        //checks each available bag. Curr using one bag
        foreach (Bag bag in bags)
        {
            if (bag.MyBagScript.AddItem(item))
            {
                return;
            }
        }
    }

    public void AddBag(Bag bag)
    {
        foreach (BagButton bagButton in bagButtons)
        {
            if (bagButton.MyBag == null)
            {
                bagButton.MyBag = bag;
                bags.Add(bag); //add bag to count for display purposes
                break;
            }
        }
    }
}
