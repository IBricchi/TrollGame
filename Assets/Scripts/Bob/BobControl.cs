using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BobControl : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 20;
	public float gravity = -9.81f;

	Vector3 vel;

	// Update is called once per frame
	void Update()
	{
		PlayerMovement();
		PlayerGravity();
	}

	void PlayerMovement(){
		float hor = Input.GetAxis("Horizontal");
		float ver = Input.GetAxis("Vertical");

		Vector3 player_movement = transform.right * hor + transform.forward * ver;
		controller.Move(player_movement * speed * Time.deltaTime);
	}

	void PlayerGravity(){
		vel.y += gravity * Time.deltaTime / 2;
		controller.Move(vel * Time.deltaTime);
	}
}
