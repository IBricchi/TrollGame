using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;


public class CameraControl : MonoBehaviour
{
	public Transform target, player;

	public float mouse_sens = 150;
	public float zoom_sens= 100;

	public float clamp_angle_min = -40;
	public float clamp_angle_max = 50;
	public float clamp_zoom_min = 3;
	public float clamp_zoom_max = 20;

	float rot_x = 0.0f;
	float pos_z = 3.0f;

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
		float zoom = Input.GetAxis("Mouse ScrollWheel") * zoom_sens * Time.deltaTime;

		pos_z += zoom;
		pos_z = Mathf.Clamp(pos_z, -clamp_zoom_max, -clamp_zoom_min);

		transform.localPosition = Vector3.forward*pos_z;
	}
}
