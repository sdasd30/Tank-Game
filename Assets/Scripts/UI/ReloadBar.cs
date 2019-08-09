using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadBar : MonoBehaviour {
	TurretMainFirePlayer player;
    GameObject reloadReady;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<TurretMainFirePlayer>();
        reloadReady = FindObjectOfType<ReloadRedy>().gameObject;
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			this.GetComponent<Slider> ().value = player.gameObject.GetComponent<TurretMainFirePlayer> ().ReturnCoolDown (); 
		}
        if (GetComponent<Slider>().value == 0)
        {
            reloadReady.SetActive(true);
        }
        else
        {
            reloadReady.SetActive(false);
        }
    }
}
