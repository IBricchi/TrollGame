using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BobControl : MonoBehaviour
{
	public CharacterController controller;

	public float speed = 20;
	public float gravity = -9.81f;

	public Transform ground_check;
	public float ground_dist = 0.4f;
	public LayerMask ground_mask;

	Vector3 vel;
	bool is_grounded = false;

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

		is_grounded = Physics.CheckSphere(ground_check.position, ground_dist, ground_mask);

		if (is_grounded && vel.y < 0)
		{
			vel.y = -2.0f;
		}

		controller.Move(vel * Time.deltaTime);
	}
}
