using UnityEngine;
using System.Collections;

public class OpenBasicDoor : MonoBehaviour {

	public GameObject _Player;
	public GameObject _Door;

	void OnTriggerStay(Collider player)
	{
		if (player == _Player.GetComponent<Collider> ())
			if (Input.GetKey (KeyCode.E))
				_Door.transform.position += 0.2f * Vector3.forward;
	}

}
