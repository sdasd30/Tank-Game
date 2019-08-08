using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Check_Enemies : MonoBehaviour {
	Enemy [] enemyList;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		enemyList = GameObject.FindObjectsOfType<Enemy> ();
		Debug.Log (enemyList.Length);
		if (enemyList.Length == 0) {
			Debug.Log ("YOU WIN");
			SceneManager.LoadScene ("Win Screen");
		}
	}
}
