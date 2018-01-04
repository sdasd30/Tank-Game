using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour {
	Player_Body_Movement player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player_Body_Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Slider>().value = player.gameObject.GetComponent<Attackable> ().returnHP(); 
	}
}
