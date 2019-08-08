using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (Rigidbody2D))]

public class MovementEnemy: MonoBehaviour {

	public float speed = 3;
	public float rotSpeed = 60;
	public float rotLimit = 60;
	public float speedLimit = 3;
	float curRotSpeed = 0;
	float curSpeed = 0;
	float m_currentRotation = 0;
	MovementPlayer player;
	Rigidbody2D m_body;
	// Use this for initialization
	void Start () {
		m_body = GetComponent<Rigidbody2D> ();
		m_currentRotation = transform.eulerAngles.z;
	}

	// Update is called once per frame
	void Update () {
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
