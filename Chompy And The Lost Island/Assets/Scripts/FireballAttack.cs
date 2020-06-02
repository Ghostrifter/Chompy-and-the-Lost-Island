using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;
    public float shootDelay;
    private float timeToFire = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireballPrefab.GetComponent<FireballMove>().fireRate;
            Invoke("Shoot", shootDelay);
        }
    }

    void Shoot()
    {
        if(Time.timeScale == 1f)
        {
            Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
        }
    }
    
}
