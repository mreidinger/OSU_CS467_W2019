using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
	public InputField inputField;

	GameController controller;

	void Awake()
	{
		controller = GetComponent<GameController>();
		inputField.onEndEdit.AddListener(AcceptStringInput);
		
	}

	void AcceptStringInput(string userInput)
	{
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
		userInput = userInput.ToLower();
		controller.LogStringWithReturn(userInput);

		char[] delimiterCharacters = { ' ' };
		string[] separatedInputWords = userInput.Split(delimiterCharacters);

		for (int i = 0; i < controller.inputActions.Length; i++)
		{
			InputAction inputAction = controller.inputActions[i];
			if (inputAction.keyWord == separatedInputWords[0].ToLower())
			{
				inputAction.RespondToInput(controller, separatedInputWords);
			}
		}

		InputComplete();
		}
		else
		{
			inputField.Select();
			inputField.ActivateInputField();
		}
	}

	void InputComplete()
	{
	//	controller.DisplayLoggedText();
		inputField.ActivateInputField();
		inputField.text = null;
	}

}