using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Friendly_Bullet : MonoBehaviour {
	Rigidbody2D m_body;
	public float speed;
	float angle;
	public void SetAngle (float rotation) {
		angle = rotation;
		m_body = GetComponent<Rigidbody2D> ();
		m_body.transform.rotation = Quaternion.Euler (new Vector3(0f,0f,rotation));
	}

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		m_body.transform.Translate (new Vector2(0f,speed * Time.deltaTime)); //new Vector2 (Mathf.Cos(angle) * speed * Time.deltaTime,Mathf.Sin(angle) * speed * Time.deltaTime));
		
	}
}
