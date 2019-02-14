using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Hi")]
public class Hi : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.LogStringWithReturn("Howdy.");
		controller.DisplayLoggedText();
	}
}