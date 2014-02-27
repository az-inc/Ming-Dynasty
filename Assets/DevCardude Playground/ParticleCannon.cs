using UnityEngine;
using System.Collections;

public enum cannonMode {
	UpDown,
	LeftRight,
	Cannon
};

public class ParticleCannon: MonoBehaviour {

	public cannonMode mode;

	// Use this for initialization
	void Start () {
		gameObject.particleSystem.enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rot = transform.rotation;

		if (Input.GetKey(KeyCode.W) && mode == cannonMode.UpDown) {
				rot.x += (float)1 * Time.deltaTime;
			}
		if (Input.GetKey (KeyCode.S) && mode == cannonMode.UpDown) {
				rot.x -= (float)1 * Time.deltaTime;
			}
		if (Input.GetKey (KeyCode.A) && mode == cannonMode.LeftRight) {
				rot.y -= (float)1 * Time.deltaTime;
			}
		if (Input.GetKey (KeyCode.D) && mode == cannonMode.LeftRight) {
				rot.y += (float)1 * Time.deltaTime;
			}
		if (Input.GetKey (KeyCode.Space) && mode == cannonMode.Cannon) {
			GameObject fire;
			fire = gameObject;
			GameObject temp = (GameObject)GameObject.Instantiate(fire);
			temp.particleSystem.enableEmission = true;
			temp.particleSystem.Emit((int)1);
			temp.particleSystem.enableEmission = false;
			GameObject.Destroy(temp);

			//gameObject.particleSystem.Emit (1);
		}

		transform.rotation = rot;
	}
}
