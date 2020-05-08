using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BobControl : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 20;

	// Update is called once per frame
	void Update()
	{
		PlayerMovement();
	}

	void PlayerMovement(){
		float hor = Input.GetAxis("Horizontal");
		float ver = Input.GetAxis("Vertical");

		Vector3 player_movement = transform.right * hor + transform.forward * ver;
		controller.Move(player_movement * speed * Time.deltaTime);
	}
}
