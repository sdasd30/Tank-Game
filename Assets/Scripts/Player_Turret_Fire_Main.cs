﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Turret_Fire_Main : MonoBehaviour {
	public Rigidbody projectile;
	public GameObject BulletPrefab;
	public Vector2 Offset;
	public float fireRate = 100;
	float coolDown = 0;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && !Input.GetKey ("r")){
			if (coolDown <= 0) { 
				float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
				GameObject bullet = GameObject.Instantiate (BulletPrefab, transform.position + new Vector3 (Offset.x * Mathf.Cos (angle), Offset.y * Mathf.Sin (angle), 0f), Quaternion.identity);
				bullet.GetComponent<Friendly_Bullet> ().SetAngle (transform.rotation.eulerAngles.z);
				Destroy (bullet, 5);
				coolDown = fireRate;
			} else {
				Debug.Log ("Press R:" + coolDown);
			}
		}
		if (Input.GetKey ("r")) {
			coolDown--;
		}
		if (coolDown == 0) {
			Debug.Log ("Ready to Fire!");
		}
	}
}
