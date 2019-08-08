using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vertical_Slider_Reload : MonoBehaviour {
	TurretMainFirePlayer player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<TurretMainFirePlayer>();
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			this.GetComponent<Slider> ().value = player.gameObject.GetComponent<TurretMainFirePlayer> ().ReturnCoolDown (); 
		}
	}
}
