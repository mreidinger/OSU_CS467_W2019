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
        //usekeycode to test
    }

    private void Save()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.OpenOrCreate);

            SaveData data = new SaveData();

            SavePlayer(data);

            bf.Serialize(file, data);

            file.Close();
        }
        catch (System.Exception e)
        {
            //delete savegame if corrupted
            Debug.LogError(e.Message);
        }
    }

    //set values in data to be saved with file pointer.
    //manipulates given data
    private void SavePlayer(SaveData data)
    {
        //creat the actual data to save ie vector3s, inventory, etc
        //use the instances to store data.
        //has class called playerdata. store valuabble
        
    }

    private void Load()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat", FileMode.Open);

            SaveData data = (SaveData)bf.Deserialize(file);

            //LoadPlayer(data);

            file.Close();

            LoadPlayer(data);
        }
        catch (System.Exception e)
        {
            //delete savegame if corrupted
            Debug.LogError(e.Message);
        }
    }

    //set values in data to be saved with file pointer
    private void LoadPlayer(SaveData data)
    {
        //set the gamevalues from deserialized values
        //set gme values from saved valued

    }
}
