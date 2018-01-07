using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vertical_Slider_Reload : MonoBehaviour {
	Player_Turret_Fire_Main player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player_Turret_Fire_Main>();
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			this.GetComponent<Slider> ().value = player.gameObject.GetComponent<Player_Turret_Fire_Main> ().ReturnCoolDown (); 
		}
	}
}
