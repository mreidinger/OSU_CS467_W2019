﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	public Text displayText;
	public InputAction[] inputActions;
	public string[] areaText;
	public GameObject dialogBox;
	public InputField textInput;
	public int dialogueToggle = 0;
	public int roomToggle = 0;
	public int roomTextSelector = 0;
	public ScrollRect myScrollRect;
	public Scrollbar newScrollBar;

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
		if (roomToggle == 0)
		{
			DisplayRoomText();
		}
		else
		{
			DisplayLoggedText();

		}
		textInput.Select();
	}

	public void DisplayRoomText()
	{
		displayText.text = areaText[roomTextSelector];
		dialogueToggle = 1;
		myScrollRect.verticalNormalizedPosition = 1f;
		dialogBox.SetActive(true);
	}

	public void DisplayLoggedText()
	{
		displayText.text = actionLog;
		dialogueToggle = 1;
		myScrollRect.verticalNormalizedPosition = 1f;
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

//			if (dialogueToggle == 0)
//			{
//				dialogBox.SetActive(false);
//			}

			if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
			{
				dialogBox.SetActive(false);
				dialogueToggle = 0;
				roomToggle = 1;
			}

		
		}
	}
}