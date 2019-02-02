using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{


	public Text dialogText;
	public GameObject dialogBox;

	public string[] lines;

	public int currentLine ;


    // Start is called before the first frame update
    void Start()
    {
		dialogText.text = lines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogBox.activeInHierarchy)
		{
			if (Input.GetButtonUp("Submit"))
			{
				currentLine++;

				if (currentLine >= lines.Length)
				{
					dialogBox.SetActive(false);
				}
				else
				{
					dialogText.text = lines[currentLine];
				}
			}
		}
    }
}
