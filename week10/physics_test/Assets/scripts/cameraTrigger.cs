using UnityEngine;
using System.Collections;

public class cameraTrigger : MonoBehaviour {
	
//	public GameObject camToActivate;

	public Camera camToActivate;

	public cameraController controller;

	// Use this for initialization
	void OnTriggerEnter(Collider other){

		controller.deactivateCameras ();
		camToActivate.enabled = true;
	}
}
