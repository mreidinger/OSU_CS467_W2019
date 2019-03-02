using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafletScript : MonoBehaviour
{
    /*Obsolete, using pickup script*/
    //can make a prefab, with itemtype as a fillin,
    //then do a switch statement to add the right type?
    //private string itemType = "Leaflet";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //print("Colliding");
            Leaflet leaflet = (Leaflet)Instantiate(InventoryScript.MyInstance.items[1]);
            InventoryScript.MyInstance.AddItem(leaflet);
            //remove item from world... destroy script?
            Destroy(gameObject);
        }
    }
}
