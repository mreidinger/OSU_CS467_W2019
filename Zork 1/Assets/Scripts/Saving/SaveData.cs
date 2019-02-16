using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SaveData
{
    public PlayerData MyPlayerData { get; set; }

    public SaveData()
    {
        //constructor, setsup game
    }
}

[Serializable]
public class PlayerData
{
    //put all game data in here.
    //have values for vector3, scenename, etc
    public int MyLevel { get; set; }

    public PlayerData(int level)
    {
        this.MyLevel = level;
    }
}