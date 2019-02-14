using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Jump")]
public class Jump : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.LogStringWithReturn("Whew thats pretty high.");
		controller.DisplayLoggedText();
	}
}
