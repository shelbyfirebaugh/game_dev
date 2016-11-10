using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;

	public GameObject[] cameras;

	// Use this for initialization
	void Start () {
//		camera1.SetActive(true);
//		camera2.SetActive(false);

		deactivateCameras ();
		cameras [0].SetActive (true);
		public int currentCam = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
//			camera1.SetActive (!camera1.active);
//			camera2.SetActive (!camera2.active);

			deactivateCameras ();

			if (currentCam < cameras.Length - 1) {
				
				currentCam += 1;
			}


		}

		}

	public void activateCameras(){

	}

	public void deactivateCameras(){

		for (int i = 0; i < cameras.Length; i++){
			cameras[i].SetActive(false);
		}
	
	}
}
