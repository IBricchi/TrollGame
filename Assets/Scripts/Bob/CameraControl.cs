using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
	InputMaster controls;

	public Transform target, player;

	public float mouse_sens = 10f;
	public float zoom_sens= 100f;

	public float clamp_angle_min = 0f;
	public float clamp_angle_max = 50f;
	public float clamp_zoom_min = 3f;
	public float clamp_zoom_max = 20f;

	float rot_x = 0.0f;
	float pos_z = 3.0f;

	Vector2 angle_vals;
	float zoom_vals = 8;

	// called once at begining
	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	// This is all for controller setup
	// Called before anything "I think"
	void Awake()
	{
		controls = new InputMaster();
		controls.Camera.Look.performed += _ => angle_vals = _.ReadValue<Vector2>();
		controls.Camera.Scroll.performed += _ => zoom_vals = _.ReadValue<Vector2>().y;
	}

	void OnEnable()
	{
		controls.Camera.Enable();
	}

	void OnDisable()
	{
		controls.Camera.Disable();
	}

	void LateUpdate()
	{
		angle_vals *= Time.deltaTime * mouse_sens;
		zoom_vals *= Time.deltaTime * zoom_sens;
		AngleControl(angle_vals);
		ZoomControl(zoom_vals);
	}

	void AngleControl(Vector2 dir){
		rot_x += dir.y;
		rot_x = Mathf.Clamp(rot_x, clamp_angle_min, clamp_angle_max);
		Quaternion rot = Quaternion.Euler(rot_x, 0, 0);

		player.Rotate(Vector3.up * dir.x);
		target.localRotation = rot;
	}

	void ZoomControl(float zoom){
		pos_z += zoom;
		pos_z = Mathf.Clamp(pos_z, -clamp_zoom_max, -clamp_zoom_min);

		transform.localPosition = Vector3.forward*pos_z;
	}
}
