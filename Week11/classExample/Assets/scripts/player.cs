using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Rigidbody rb;
	public float acc; //acceleration
	private float currentAcc; //current acceleration
	private bool grounded;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			currentAcc = acc;
		} else {
			currentAcc = 0;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.RotateAround (transform.position, transform.up, -5);
		}

		if (Input.GetKey (KeyCode.R)) {
			transform.RotateAround (transform.position, transform.up, 5);
		}

		if (Input.GetKey (KeyCode.Space)) {
			if (grounded) {
				rb.AddForce (transform.up * 10, ForceMode.Impulse);
			}
		}
			
	
	}

	void onCollisionStay(Collision col){
		if (col.gameObject.tag == "ground") {
			grounded = true;
		}
	}

	void onCollisionExit(Collision col){
		if (col.gameObject.tag == "ground") {
			grounded = false;
		}
	}

	void FixedUpdate(){
		// for things to do with physics called at certain times, frame rate independent

		rb.AddForce (transform.forward * currentAcc, ForceMode.Acceleration);
	}
}
