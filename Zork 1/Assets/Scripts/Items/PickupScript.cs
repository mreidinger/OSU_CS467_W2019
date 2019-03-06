using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script used to add objects to inventory
//attached to pickup prefab.
//prefab needs to specify itemType to work correctly.
public class PickupScript : MonoBehaviour
{
    public string itemType;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //check for each item available and add.
            //itemtype references the item array found under the inventoryScript
            //gameobject.
            //NOTE
            //need to check inventory is not full
            //need to check if inventory is full to not destroy onscreen
            //object
            //END NOTE
            if (itemType == "Leaflet")
            {
                Leaflet leaflet = (Leaflet)Instantiate(InventoryScript.MyInstance.items[1]);
                InventoryScript.MyInstance.AddItem(leaflet);
            }
            else if (itemType == "Egg")
            {
                Egg egg = (Egg)Instantiate(InventoryScript.MyInstance.items[2]);
                InventoryScript.MyInstance.AddItem(egg);
            }
            else if (itemType == "Sword")
            {
                Sword sword = (Sword)Instantiate(InventoryScript.MyInstance.items[3]);
                InventoryScript.MyInstance.AddItem(sword);
            }
            else if (itemType == "Trident")
            {
                Trident trident = (Trident)Instantiate(InventoryScript.MyInstance.items[4]);
                InventoryScript.MyInstance.AddItem(trident);
            }
            else if (itemType == "Airpump")
            {
                AirPump ap = (AirPump)Instantiate(InventoryScript.MyInstance.items[5]);
                InventoryScript.MyInstance.AddItem(ap);
            }
            else if (itemType == "Bar")
            {
                PlatinumBar bar = (PlatinumBar)Instantiate(InventoryScript.MyInstance.items[6]);
                InventoryScript.MyInstance.AddItem(bar);
            }
            else if (itemType == "Knife")
            {
                Knife knife = (Knife)Instantiate(InventoryScript.MyInstance.items[7]);
                InventoryScript.MyInstance.AddItem(knife);
            }
            else if (itemType == "Rope")
            {
                Rope rope = (Rope)Instantiate(InventoryScript.MyInstance.items[8]);
                InventoryScript.MyInstance.AddItem(rope);
            }
            else if (itemType == "Skull")
            {
                Skull skull = (Skull)Instantiate(InventoryScript.MyInstance.items[9]);
                InventoryScript.MyInstance.AddItem(skull);
            }
            else if (itemType == "Sack")
            {
                Sack sack = (Sack)Instantiate(InventoryScript.MyInstance.items[10]);
                InventoryScript.MyInstance.AddItem(sack);
            }
            else if (itemType == "Lantern")
            {
                Lantern lantern = (Lantern)Instantiate(InventoryScript.MyInstance.items[11]);
                InventoryScript.MyInstance.AddItem(lantern);
            }
            else if (itemType == "Bottle")
            {
                Bottle bottle = (Bottle)Instantiate(InventoryScript.MyInstance.items[12]);
                InventoryScript.MyInstance.AddItem(bottle);
            }
            else if (itemType == "Candle")
            {
                Candle candle = (Candle)Instantiate(InventoryScript.MyInstance.items[13]);
                InventoryScript.MyInstance.AddItem(candle);
            }
            else if (itemType == "BlackBook")
            {
                BlkBook book = (BlkBook)Instantiate(InventoryScript.MyInstance.items[14]);
                InventoryScript.MyInstance.AddItem(book);
            }
            else if (itemType == "PlasticPile")
            {
                PlasticPile plastic = (PlasticPile)Instantiate(InventoryScript.MyInstance.items[15]);
                InventoryScript.MyInstance.AddItem(plastic);
            }







            

            //continue with other objects, sword, sack etc...
            //remove item from world... destroy script?
            Destroy(gameObject);
        }
        
    }
}
