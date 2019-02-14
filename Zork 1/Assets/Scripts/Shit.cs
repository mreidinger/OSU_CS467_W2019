using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Shit")]
public class Shit : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.LogStringWithReturn("Naughty Naughty, thats what you do on the toilet.");
		controller.DisplayLoggedText();
	}
}
