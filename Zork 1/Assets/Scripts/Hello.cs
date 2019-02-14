using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Hello")]
public class Hello : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.LogStringWithReturn("How art thou today.");
		controller.DisplayLoggedText();
	}
}
