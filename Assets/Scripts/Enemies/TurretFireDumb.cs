using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFireDumb : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Vector2 Offset;
    public float fireRate = 3;
    public float coolDown = 3;
    // Update is called once per frame
    void Update()
    {
        if (coolDown <= 0)
        {
            float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
            GameObject bullet = GameObject.Instantiate(BulletPrefab, transform.position + new Vector3(Offset.x * Mathf.Cos(angle), Offset.y * Mathf.Sin(angle), 0f), Quaternion.identity);
            bullet.GetComponent<Projectile>().SetAngle(transform.rotation.eulerAngles.z);
            Destroy(bullet, 5);
            coolDown = fireRate;
        }
    coolDown -= Time.deltaTime;
    }
}
