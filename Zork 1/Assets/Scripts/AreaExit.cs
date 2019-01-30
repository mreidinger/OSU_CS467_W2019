using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
     public string areaToLoad;

     public string areaTransitinName;

     //public AreaEntrance TheEntrance;
     
     // Start is called before the first frame update
    void Start()
    {
         //TheEntrance.transitionName = areaTransitinName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D other)
     {
          if (other.tag == "Player")
          {
               SceneManager.LoadScene(areaToLoad);

               PlayerController.instance.areaTransitionName = areaTransitinName;
          }
     }
    
}
