﻿using UnityEngine;
using System.Collections;

public class PrincessController : MonoBehaviour {

	public float speed;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;

	public GameObject block;



//	private Rigidbody2D rb2d;

	void Start(){
//		rb2d = GetComponent<Rigidbody2D> ();

	}
	void Update() {
		float h = speed * Input.GetAxis("Mouse ScrollWheel");
		transform.Translate(h, 0, 0);

		if (Input.GetMouseButton (0) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}

		if (Input.GetMouseButton (1) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Vector3 screenPoint = Input.mousePosition;
			screenPoint.z = 10.0f; //distance of the plane from the camera
			screenPoint = Camera.main.ScreenToWorldPoint(screenPoint);
			Instantiate (block, screenPoint, shotSpawn.rotation);
		}
		

//		float moveH = Input.GetAxis ("Mouse ScrollWheel");
//
//		Vector2 movement = new Vector2 (moveH, 0);
//		rb2d.AddForce (movement * speed);
	}
}
