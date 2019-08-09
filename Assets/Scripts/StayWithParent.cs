using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWithParent : MonoBehaviour {

	public Vector2 offset;
    public GameObject parent;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = parent.GetComponent<Transform>().position;
        transform.localPosition = offset;
	}
}
