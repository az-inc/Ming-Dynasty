using UnityEngine;
using System;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public Camera MainCamera;

	// Use this for initialization
	void Start () {
		if (gameObject.tag == "CameraPoint" && gameObject.name == "MainCameraPoint") {
			CameraPointsManager.MainCameraPos = gameObject.transform.position;
			CameraPointsManager.MainCameraRot = gameObject.transform.rotation;
		} else if (gameObject.tag == "CameraPoint" && gameObject.name == "ParticleCannonCameraPoint") {
			CameraPointsManager.ParticleCannonCameraPos = gameObject.transform.position;
			CameraPointsManager.ParticleCannonCameraRot = gameObject.transform.rotation;
		} else if (gameObject.tag == "CameraPoint" && gameObject.name == "DubstepCannonCameraPoint") {
			CameraPointsManager.ParticleCannonCameraPos = gameObject.transform.position;
			CameraPointsManager.ParticleCannonCameraRot = gameObject.transform.rotation;
		} else if (gameObject.tag == "MainCamera") {
			MainCamera = gameObject.camera;
		}
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.Alpha1) && gameObject.tag == "MainCamera") {
			CameraPointsManager.currentPoint = 1;
		}
		if (Input.GetKey (KeyCode.Alpha2) && gameObject.tag == "MainCamera") {
			CameraPointsManager.currentPoint = 2;
		}
		if (Input.GetKey (KeyCode.Alpha3) && gameObject.tag == "MainCamera") {
			CameraPointsManager.currentPoint = 3;
		}

		if (CameraPointsManager.currentPoint == 1) {
						MainCamera.transform.position = CameraPointsManager.MainCameraPos;
						MainCamera.transform.rotation = CameraPointsManager.MainCameraRot;
				} else if (CameraPointsManager.currentPoint == 2) {
						MainCamera.transform.position = CameraPointsManager.ParticleCannonCameraPos;
						MainCamera.transform.rotation = CameraPointsManager.ParticleCannonCameraRot;
				} else if (CameraPointsManager.currentPoint == 3) {
						MainCamera.transform.position = CameraPointsManager.DubstepCannonCameraPos;
						MainCamera.transform.rotation = CameraPointsManager.DubstepCannonCameraRot;
				}
		else {}
	}
}
