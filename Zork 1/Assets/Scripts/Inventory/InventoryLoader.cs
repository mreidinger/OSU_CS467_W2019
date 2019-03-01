using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryLoader : MonoBehaviour
{
    //drag in the object to be loaded in unity
    public GameObject inventoryCanvas;
    // Start is called before the first frame update
    void Start()
    {
        if (CanvasScript.MyCanvasInstance == null)
        {
            Instantiate(inventoryCanvas);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
