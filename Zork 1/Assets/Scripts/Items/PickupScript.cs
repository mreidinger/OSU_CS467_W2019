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
            //there must be a more efficient way, but I haven't
            //thought of it.
            //need to check inventory is not full
            //need to check if inventory is full to not destroy onscreen
            //object
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

            //continue with other objects, sword, sack etc...
            //remove item from world... destroy script?
            Destroy(gameObject);
        }
        
    }
}
