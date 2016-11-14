using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

//	public GameObject camera1;
//	public GameObject camera2;


	int currentCam;

	public Camera[] cams;

	// Use this for initialization
	void Start () {
//		camera1.SetActive(true);
//		camera2.SetActive(false);

//		deactivateCameras ();
		cams [0].enabled = true;
		currentCam = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
//			camera1.SetActive (!camera1.active);
//			camera2.SetActive (!camera2.active);

			deactivateCameras ();

			if (currentCam < cams.Length - 1) {
				
				currentCam += 1;
			} else {
				currentCam = 0;
			}

			activateCameras (currentCam);

		}

		}

	public void activateCameras(int _index){
		cams [_index].enabled = true;

		currentCam = _index;
	}

	public void deactivateCameras(){

		for (int i = 0; i < cams.Length; i++){
			cams[i].enabled = false;
		}
	
	}
}
