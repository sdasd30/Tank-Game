using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (Rigidbody2D))]

public class MovementPlayer : MonoBehaviour {
	public float speed = 3;
	public float rotSpeed = 60;
	public float rotLimit = 60;
	public float speedLimit = 3;
	float curRotSpeed = 0;
	float curSpeed = 0;
	float m_currentRotation;
	Rigidbody2D m_body;
	// Use this for initialization
	void Start () {
		m_body = GetComponent<Rigidbody2D> ();
		m_currentRotation = transform.eulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a")){
			//Debug.Log (curRotSpeed);
			if (curRotSpeed < rotLimit) {
				curRotSpeed += rotSpeed * Time.deltaTime;
			}
		}
		if (Input.GetKey("d")){
			//Debug.Log (curRotSpeed);
			if (curRotSpeed > -rotLimit) {
				curRotSpeed -= rotSpeed * Time.deltaTime;
			}
		}
		if (Input.GetKey("w")){
			if (curSpeed < speedLimit) {
				curSpeed += speed;
			}
		}
		if (Input.GetKey("s")){
			if (curSpeed > -speedLimit) {
				curSpeed -= speed;
			}
		}
		if (Input.GetKey("c")){ //Kill Rot
			if (curRotSpeed > 4f) { //For Rotation
				curRotSpeed -= 4f;
			} else if (curRotSpeed < -8f) {
				curRotSpeed += 4f;
			} else {
				curRotSpeed = 0f;
			}
		}

		if (Input.GetKey ("z")) { //Kill speed
			if (curSpeed > .1f) { //For Regular Movement
				curSpeed -= .1f;
			} else if (curSpeed < -.1f){
				curSpeed += .1f;
			} else {
				curSpeed = 0f;
			}
		}
		if (Input.GetKey("x")){ //Stop all Movement
			if (curSpeed > .1f) { //For Regular Movement
				curSpeed -= .1f;
			} else if (curSpeed < -.1f){
				curSpeed += .1f;
			} else {
				curSpeed = 0f;
			}

			if (curRotSpeed > 4f) { //For Rotation
				curRotSpeed -= 4f;
			} else if (curRotSpeed < -8f) {
				curRotSpeed += 4f;
			} else {
				curRotSpeed = 0f;
			}

		}
		m_currentRotation += curRotSpeed * Time.deltaTime;
		m_body.transform.Translate (new Vector2(0f,curSpeed * Time.deltaTime));
		m_body.transform.rotation = Quaternion.Euler (new Vector3(0f,0f,m_currentRotation));
	}
	public float ReturnSpeed(){
		return curSpeed;
	}

	public float ReturnRotation(){
		return curRotSpeed;
	}
}
