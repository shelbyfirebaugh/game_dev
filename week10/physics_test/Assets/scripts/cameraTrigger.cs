using UnityEngine;
using System.Collections;

public class cameraTrigger : MonoBehaviour {
	

	public Camera camToActivate;

	public Camera[] cams;

//	public cameraController controller;

	// Use this for initialization
	public void OnTriggerEnter(Collider other){

		deactivateCameras ();
		camToActivate.enabled = true;
	}

	public void deactivateCameras(){

		for (int i = 0; i < cams.Length; i++){
			cams[i].enabled = false;
		}

	}
}
