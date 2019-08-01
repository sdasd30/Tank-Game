using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWithParent : MonoBehaviour {

	public Vector2 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = offset;
	}
}
