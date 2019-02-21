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

    /*public int MyLevel { get; set; }
    //was just saving the characters level, not actual
    //scene level!!
    public PlayerData(int level)
    {
        this.MyLevel = level;
    }
    */
    public string ptag { get; set; }
    public SerializableVector3 playerpos { get; set; }
    //save transform values
    public float posx { get; set; }
    public float posy { get; set; }
    public float posz { get; set; }
}