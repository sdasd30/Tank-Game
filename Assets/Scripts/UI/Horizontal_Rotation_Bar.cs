using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Horizontal_Rotation_Bar : MonoBehaviour {
	Player_Movement player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player_Movement>();
	}

	// Update is called once per frame
	void Update () {
		if (player != null)
		this.GetComponent<Slider>().value = player.gameObject.GetComponent<Player_Movement> ().ReturnRotation(); 
	}
}
