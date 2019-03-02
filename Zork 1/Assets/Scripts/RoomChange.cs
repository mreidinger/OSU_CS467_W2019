using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChange : MonoBehaviour
{
	public GameController controller;
	public int roomSwitch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			controller.roomTextSelector = roomSwitch;
			controller.roomToggle = 0;
			StartCoroutine(WaitOneSecToDeactivateTrash());

			controller.DisplayRoomText();
		}
	}

	IEnumerator WaitOneSecToDeactivateTrash()
	{
		yield return new WaitForSeconds(500);
	}
}
