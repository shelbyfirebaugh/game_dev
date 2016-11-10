using UnityEngine;
using System.Collections;

public class cameraTrigger : MonoBehaviour {
	
//	public GameObject camToActivate;

	public int camNumber;

	public cameraController controller;

	// Use this for initialization
	void OnTriggerEnter(Collider other){

		controller.deactivateCameras ();
		camToActivate.SetActive (true);
	}
}
