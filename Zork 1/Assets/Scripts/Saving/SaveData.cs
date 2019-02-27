using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SaveData
{
    public PlayerData MyPlayerData { get; set; }

    public InventoryData MyInventoryData { get; set; }

    public SaveData()
    {
        //constructor, setsup game
        MyInventoryData = new InventoryData();
    }
}

[Serializable]
public class PlayerData
{
    //put all game data in here.
    //have values for vector3, scenename, etc

    /*public int MyLevel { get; set; }
    //was just saving the characters level, not actual
    //scene level!!
    public PlayerData(int level)
    {
        this.MyLevel = level;
    }
    */
    public SerializableVector3 Playerpos { get; set; } //within world
    public string AreaToLoad { get; set; }
    public float DirX { get; set; } //direction
    public float DirY { get; set; }
    //save transform values
    //public float posx { get; set; }
    //public float posy { get; set; }
    //public float posz { get; set; }
}

[Serializable]
public class ItemData
{
    public string MyTitle { get; set; }
    public int MySlotIdx { get; set; }
}

[Serializable]
public class InventoryData
{
    public List<BagData> MyBags { get; set; }
    //want to see if constructors ease workload
    public InventoryData()
    {
        MyBags = new List<BagData>();
    }
}

[Serializable]
public class BagData
{
    public int MySlotCount { get; set; } //curr at 16 slots per
    public int MyBagIdx { get; set; }

    //try with constructor
    public BagData(int count, int idx)
    {
        MySlotCount = count;
        MyBagIdx = idx;
    }
}