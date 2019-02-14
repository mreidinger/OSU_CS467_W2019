using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	public Text displayText;
	public InputAction[] inputActions;
	public GameObject dialogBox;
	public InputField textInput;
	public int dialogueToggle = 0;

	//[HideInInspector]
	//public RoomNavigation roomNavigation;
	[HideInInspector]
	public List<string> interactionDescriptionsInRoom = new List<string>();

	//List<string> actionLog = new List<string>();
	string actionLog;
	// Use this for initialization
	void Awake()
	{
		dialogBox.SetActive(false);
	//	roomNavigation = GetComponent<RoomNavigation>();
	}

	void Start()
	{
	//	DisplayRoomText();
		DisplayLoggedText();
		textInput.Select();
	}

	public void DisplayLoggedText()
	{
	//	string logAsText = string.Join("\n", actionLog.ToArray());

	//	displayText.text = logAsText;

		displayText.text = actionLog;
		dialogueToggle = 1;
		dialogBox.SetActive(true);
	}

	public void LogStringWithReturn(string stringToAdd)
	{
	//	actionLog.Add(stringToAdd + "\n");

		actionLog = stringToAdd;
	}

	// Update is called once per frame
	void Update()
	{
		if (dialogBox.activeInHierarchy)
		{

			if (dialogueToggle == 0)
			{
				dialogBox.SetActive(false);
			}

			if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
			{
				dialogueToggle = 0;
			}

		
		}
	}
}