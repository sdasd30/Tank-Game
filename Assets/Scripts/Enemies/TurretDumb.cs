using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDumb : MonoBehaviour
{
    public float rotationSpeed;
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, transform.eulerAngles.z - rotationSpeed * Time.deltaTime));
    }
}
