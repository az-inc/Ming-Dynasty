// Dubstep Cannon, 'cause the one's copyrighted.
// The songs are probably copyrighted too.

using UnityEngine;
using System.Collections;

public class DubstepCannon: MonoBehaviour {
	public int currentSong;

	// Use this for initialization
	void Start () {
		if (gameObject.name == "DubstepCannonWeaponEffect") {
						gameObject.particleSystem.enableEmission = false;
				}
	}
	
	// Update is called once per frame
	void Update () {
		//Quaternion rot = transform.rotation;

		/*
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
		*/
		if (Input.GetKeyDown (KeyCode.Space)) {
			fireCannon(1);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			gameObject.audio.Stop();
			gameObject.particleSystem.enableEmission = false;
		}

		//transform.rotation = rot;
	}

	void fireCannon(int song){
		gameObject.audio.Play ();
		//do the step up thing like in the song
		gameObject.particleSystem.enableEmission = true;
	}
}