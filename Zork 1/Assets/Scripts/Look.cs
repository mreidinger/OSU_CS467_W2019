using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Zork 1/Actions/Look")]

public class Look : InputAction
{
	public override void RespondToInput(GameController controller, string[] separatedInputWords)
	{
		controller.roomToggle = 0;
		controller.DisplayRoomText();
	}
}
