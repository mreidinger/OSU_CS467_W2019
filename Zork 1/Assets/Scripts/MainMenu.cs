using System.Collections;
using System.Collections.Generic;
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
     }

     public void Exit()
     {
          // currently not saving on exit qsCD
          Application.Quit();
     }
}
