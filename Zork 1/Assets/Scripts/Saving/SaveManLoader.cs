using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManLoader : MonoBehaviour
{
    public GameObject saveManager;
    // Start is called before the first frame update
    void Start()
    {
        if (SaveManager.MySaveInstance == null)
        {
            Instantiate(saveManager);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
