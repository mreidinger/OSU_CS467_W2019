using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Save()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.OpenOrCreate);

            SaveData data = new SaveData();

            SavePlayer(data);

            file.Close();
        }
        catch (System.Exception)
        {
            //delete savegame if corrupted
        }
    }

    //set values in data to be saved with file pointer
    private void SavePlayer(SaveData data)
    {
        //creat the actual data to save ie vector3s, inventory, etc
        //data.MyPlayerData = new PlayerData(Player.MyInstance.MyLevel);
    }
}
