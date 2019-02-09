using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Fuck")]
public class Fuck : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.LogStringWithReturn("Such language in a high-class establishment like this!");
		controller.DisplayLoggedText();
	}
}
