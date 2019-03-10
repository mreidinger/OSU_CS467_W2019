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
            //check if full so we can add the items
            if (InventoryScript.MyInstance.MyEmptySlotCount > 0)
            {
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
                else if (itemType == "Buoy")
                {
                    Buoy buoy = (Buoy)Instantiate(InventoryScript.MyInstance.items[16]);
                    InventoryScript.MyInstance.AddItem(buoy);
                }
                else if (itemType == "Shovel")
                {
                    Shovel shovel = (Shovel)Instantiate(InventoryScript.MyInstance.items[17]);
                    InventoryScript.MyInstance.AddItem(shovel);
                }
                else if (itemType == "Scarab")
                {
                    Scarab scarab = (Scarab)Instantiate(InventoryScript.MyInstance.items[18]);
                    InventoryScript.MyInstance.AddItem(scarab);
                }
                else if (itemType == "PotOfGold")
                {
                    PotOfGold gold = (PotOfGold)Instantiate(InventoryScript.MyInstance.items[19]);
                    InventoryScript.MyInstance.AddItem(gold);
                }
                else if (itemType == "Bracelet")
                {
                    Bracelet bracelet = (Bracelet)Instantiate(InventoryScript.MyInstance.items[20]);
                    InventoryScript.MyInstance.AddItem(bracelet);
                }
                else if (itemType == "Coal")
                {
                    Coal coal = (Coal)Instantiate(InventoryScript.MyInstance.items[21]);
                    InventoryScript.MyInstance.AddItem(coal);
                }
                else if (itemType == "Figurine")
                {
                    Figurine fig = (Figurine)Instantiate(InventoryScript.MyInstance.items[22]);
                    InventoryScript.MyInstance.AddItem(fig);
                }
                else if (itemType == "Diamond")
                {
                    Diamond diamond = (Diamond)Instantiate(InventoryScript.MyInstance.items[23]);
                    InventoryScript.MyInstance.AddItem(diamond);
                }
                else if (itemType == "Torch")
                {
                    Torch torch = (Torch)Instantiate(InventoryScript.MyInstance.items[24]);
                    InventoryScript.MyInstance.AddItem(torch);
                }
                else if (itemType == "Coins")
                {
                    Coins coins = (Coins)Instantiate(InventoryScript.MyInstance.items[25]);
                    InventoryScript.MyInstance.AddItem(coins);
                }
                else if (itemType == "Key")
                {
                    Key key = (Key)Instantiate(InventoryScript.MyInstance.items[26]);
                    InventoryScript.MyInstance.AddItem(key);
                }
                else if (itemType == "Matches")
                {
                    Matches matches = (Matches)Instantiate(InventoryScript.MyInstance.items[27]);
                    InventoryScript.MyInstance.AddItem(matches);
                }
                else if (itemType == "Wrench")
                {
                    Wrench wrench = (Wrench)Instantiate(InventoryScript.MyInstance.items[28]);
                    InventoryScript.MyInstance.AddItem(wrench);
                }
                else if (itemType == "Screwdriver")
                {
                    Screwdriver sd = (Screwdriver)Instantiate(InventoryScript.MyInstance.items[29]);
                    InventoryScript.MyInstance.AddItem(sd);
                }
                else if (itemType == "Jewels")
                {
                    Jewels jewels = (Jewels)Instantiate(InventoryScript.MyInstance.items[30]);
                    InventoryScript.MyInstance.AddItem(jewels);
                }
                else if (itemType == "Coffin")
                {
                    Coffin coffin = (Coffin)Instantiate(InventoryScript.MyInstance.items[31]);
                    InventoryScript.MyInstance.AddItem(coffin);
                }
                else if (itemType == "Chalice")
                {
                    Chalice chalice = (Chalice)Instantiate(InventoryScript.MyInstance.items[32]);
                    InventoryScript.MyInstance.AddItem(chalice);
                }
                //the following items should not be displayed in the world
                //but going to add just in case we revamp how these items
                //are obtained.
                else if(itemType == "Garlic")
                {
                    Garlic garlic = (Garlic)Instantiate(InventoryScript.MyInstance.items[33]);
                    InventoryScript.MyInstance.AddItem(garlic);
                }
                else if(itemType == "Sceptre")
                {
                    Sceptre sep = (Sceptre)Instantiate(InventoryScript.MyInstance.items[34]);
                    InventoryScript.MyInstance.AddItem(sep);
                }






                
                Destroy(gameObject);
            }
            //probably want to utilize CLI popup here
            else
            {
                Debug.Log("Bag full");
            }
        }
        
    }
}
