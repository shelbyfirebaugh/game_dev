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


//		deactivateCameras ();
//
//		activateCameras (currentCam);

//			deactivateCameras ();
//
//			if (currentCam < cams.Length - 1) {
//				
//				currentCam += 1;
//			} else {
//				currentCam = 0;
//			}
//
//			activateCameras (currentCam);


		}

	public void activateCameras(currentCam){
		cams [currentCam].enabled = true;

//		currentCam = _index;
	}

	public void deactivateCameras(){

		for (int i = 0; i < cams.Length; i++){
			cams[i].enabled = false;
		}
	
	}
}
