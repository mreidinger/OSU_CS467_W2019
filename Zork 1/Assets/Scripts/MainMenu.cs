using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     public string newGameScene;

     public SaveManager loadSave;
     
     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {

     }

     public void Continue()
     {

          loadSave.Load();
     }

     public void NewGame()
     {
          SceneManager.LoadScene(newGameScene);
          PlayerPrefs.SetInt("cyclops_deaths", 0);
          PlayerPrefs.SetInt("troll_deaths", 0);
          PlayerPrefs.SetInt("bat_deaths", 0);
     }

     public void Exit()
     {
          // currently not saving on exit qsCD
          Application.Quit();
     }

}
