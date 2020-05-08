using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	public Transform target, player;

	public float mouse_sens = 150;

	public float clamp_angle_min = -40;
	public float clamp_angle_max = 50;

	float rot_x = 0.0f;

	// Update is called once per frame
	void LateUpdate()
	{
		CamControl();
	}

	void CamControl(){
		AngleControl();
		ZoomControl();
	}

	void AngleControl(){
		float inx = Input.GetAxis("Mouse X") * mouse_sens * Time.deltaTime;
		float iny = Input.GetAxis("Mouse Y") * mouse_sens * Time.deltaTime;

		rot_x += iny;
		rot_x = Mathf.Clamp(rot_x, clamp_angle_min, clamp_angle_max);
		Quaternion rot = Quaternion.Euler(rot_x, 0, 0);

		player.Rotate(Vector3.up * inx);
		target.localRotation = rot;
	}

	void ZoomControl(){

	}
}
