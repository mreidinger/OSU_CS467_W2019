using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    //public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {
        //usekeycode to test
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Save();
        }
        //usekeycode to test
        if (Input.GetKeyDown(KeyCode.R))
        {
            Load();
        }
    }

    public void Save()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "TestSave1.dat", FileMode.OpenOrCreate);

            SaveData data = new SaveData();
            Debug.Log("Before calling save()");
            SavePlayer(data);
            Debug.Log("After calling save()");

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
    public void SavePlayer(SaveData data)
    {
        Debug.Log("In saveplayer, about to get transform");
        //creat the actual data to save ie vector3s, inventory, etc
        //use the instances to store data.
        //has class called playerdata. store valuabble
        //save transform values.... is null because player not instantiated yet???

        /////////////////////////////////////////////////////////////////////////////
        ///TODO: revamp inventory to store in some container for saving and loading
        ///or figure out how to save game objects
        /////////////////////////////////////////////////////////////////////////////
        Debug.Log("creating playerdata instane");
        data.MyPlayerData = new PlayerData();
        Debug.Log("done creating instance");
        string playerTag = PlayerController.instance.tag;
        Vector3 temp = PlayerController.instance.transform.position;
        SerializableVector3 target = (SerializableVector3)(temp);
        if (target.y == 0)
        {
            Debug.Log("target y is 0");
        }
        else
        {
            Debug.Log("target y is " + target.y);
        }
        Debug.Log("trying to get x y z : " + target.x);
        Debug.Log("trying to save tag");
        data.MyPlayerData.ptag = playerTag;
        Debug.Log("finished saving tag");
        data.MyPlayerData.playerpos = target;
        Debug.Log("data stored");
        Debug.Log("exiting saveplayer");
        
    }

    public void Load()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "TestSave1.dat", FileMode.Open);

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
    public void LoadPlayer(SaveData data)
    {
        //set the gamevalues from deserialized values
        //set gme values from saved valued
        Debug.Log("about to call loadplayer");
        SerializableVector3 oldData = data.MyPlayerData.playerpos;
        PlayerController.instance.transform.position = (Vector3)oldData;
        Debug.Log("after call to loadplayer");
    }
}
