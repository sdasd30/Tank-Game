using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (Rigidbody2D))]

public class Player_Turret_Rotate : MonoBehaviour {
	Rigidbody2D m_body;
	public float rotSpeed = 90;
	public float rotLimit = 180;
	float curRotSpeed = 0;
	float m_currentRotation = 0;
	// Use this for initialization
	void Start () {
		m_body = GetComponent<Rigidbody2D> ();

	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left")){
			//Debug.Log (curRotSpeed);
			if (curRotSpeed < rotLimit) {
				curRotSpeed += rotSpeed * Time.deltaTime;
			}
		}
		if (Input.GetKey ("right")) {
			//Debug.Log (curRotSpeed);
			if (curRotSpeed > -rotLimit) {
				curRotSpeed -= rotSpeed * Time.deltaTime;
			}

		}


		if (!Input.GetKey ("right") && curRotSpeed < 1f && curRotSpeed != 0) { //Slow stop
			if (curRotSpeed > -2f) {
				curRotSpeed = 0f;
			}
			curRotSpeed += 4f;
		}
			
		if (!Input.GetKey ("left") && curRotSpeed > -1f && curRotSpeed != 0) { //Slow Stop
			if (curRotSpeed < 2f) {
				curRotSpeed = 0f;
			}
			curRotSpeed -= 4f;
		}
			
		m_currentRotation += curRotSpeed * Time.deltaTime;
		m_body.transform.rotation = Quaternion.Euler (new Vector3(0f,0f,m_currentRotation));
	}
}
