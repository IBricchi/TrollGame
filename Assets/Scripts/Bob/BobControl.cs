using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.UI;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BobControl : MonoBehaviour
{
	public CharacterController controller;
	InputMaster controls;

	public float speed = 10f;
	public float gravity = -20f;
	public float jump_height = 3f;

	public Transform ground_check;
	public float ground_dist = 0.4f;
	public LayerMask ground_mask;

	public Vector3 vel;
	public bool is_grounded = false;

	public bool run = false;
	float run_mult = 1f;

	Vector2 move_vals;
	bool jump_val;

	// Update is called once per frame
	void Update()
	{
		PlayerMovement(move_vals);
		PlayerGravity();
	}

	// This is all for controller setup
	// Called before anything "I think"
	void Awake()
	{
		controls = new InputMaster();
		controls.Bob.Move.performed += _ => move_vals = _.ReadValue<Vector2>();
		controls.Bob.Move.canceled += _ => move_vals = Vector2.zero;
		controls.Bob.Jump.performed += _ => jump_val = true;
		controls.Bob.Jump.canceled += _ => jump_val = false;
		controls.Bob.CTR.performed += _ => run = true;
		controls.Bob.CTR.canceled += _ => run = false;
	}

	public void OnEnable()
	{
		controls.Bob.Enable();
	}

	public void OnDisable()
	{
		controls.Bob.Disable();
	}

	void PlayerMovement(Vector2 direction){
		float hor = direction.x;
		float ver = direction.y;

		Vector3 player_movement = transform.right * hor + transform.forward * ver;

		controller.Move(player_movement * speed * (run ? run_mult : 1) * Time.deltaTime);
	}

	void PlayerGravity(){
		vel.y += gravity * Time.deltaTime / 2;

		is_grounded = Physics.CheckSphere(ground_check.position, ground_dist, ground_mask);

		if (is_grounded && vel.y < 0)
		{
			vel.y = -2.0f;
		}

		if(jump_val && is_grounded){
			PlayerJump();
		}

		controller.Move(vel * Time.deltaTime);
	}

	void PlayerJump(){
		vel.y = Mathf.Sqrt(jump_height * -2 * gravity);
		controller.Move(vel * Time.deltaTime);
	}
}

