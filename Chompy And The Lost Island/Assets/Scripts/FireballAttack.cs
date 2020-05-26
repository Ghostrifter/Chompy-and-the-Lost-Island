using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Shoot();
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
