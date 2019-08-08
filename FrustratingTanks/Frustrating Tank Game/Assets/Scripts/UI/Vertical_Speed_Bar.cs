using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vertical_Speed_Bar : MonoBehaviour {
	MovementPlayer player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<MovementPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null)
		this.GetComponent<Slider>().value = player.gameObject.GetComponent<MovementPlayer> ().ReturnSpeed(); 
	}
}
