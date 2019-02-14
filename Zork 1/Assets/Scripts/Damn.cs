using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Damn")]
public class Damn : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.LogStringWithReturn("My toe!!!!!");
		controller.DisplayLoggedText();
	}
}