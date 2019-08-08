using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFireEnemy : MonoBehaviour {
	TurretRotateEnemy Turret;
	public Rigidbody projectile;
	public GameObject BulletPrefab;
	public Vector2 Offset;
	public float fireRate = 100;
	public float coolDown = 0;
	// Use this for initialization
	void Start () {
		Turret = GetComponent<TurretRotateEnemy> ();
	}

	// Update is called once per frame
	void Update () {
		{
			if (Mathf.Abs (Mathf.DeltaAngle (Turret.direction, Turret.angle) + 90) < 4) {
				if (coolDown <= 0) { 
					float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
					GameObject bullet = GameObject.Instantiate (BulletPrefab, transform.position + new Vector3 (Offset.x * Mathf.Cos (angle), Offset.y * Mathf.Sin (angle), 0f), Quaternion.identity);
					bullet.GetComponent<Projectile> ().SetAngle (transform.rotation.eulerAngles.z);
					Destroy (bullet, 5);
					coolDown = fireRate;
				}
			}
			coolDown--;
		}
	}
}
