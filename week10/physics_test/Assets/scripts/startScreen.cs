using UnityEngine;
using System.Collections;

public class startScreen : MonoBehaviour {

	public Canvas message;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			message.enabled = false;
		}
	
	}
		
}
