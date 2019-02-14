using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{


	public Text dialogText;
	public GameObject dialogBox;

	public string lines;

	public int displayTextCheck = 0 ;


    // Start is called before the first frame update
    void Start()
    {
		dialogBox.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogBox.activeInHierarchy)
		{
			
				if (Input.GetButtonUp("Submit"))
				{
					dialogBox.SetActive(false);
				}
			
		}
    }
}
