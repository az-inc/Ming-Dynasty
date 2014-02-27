using UnityEngine;
using System.Collections;

public class CameraAutoMove : MonoBehaviour {
	public decimal rotateMul = 1;
	public decimal transMul = 1;

	public Keyframe camKey;

	// define all the keyframes
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rot = transform.rotation;
		Vector3 pos = transform.position;

		//object camera = GameObject.FindGameObjectWithTag("Main");

		rot.y += (float)1 * (float)rotateMul * Time.deltaTime;
		transform.rotation = rot;

		pos.x -= (float)1 * (float)transMul * Time.deltaTime;
		transform.position = pos;
	}
}
