using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;
    public float shootDelay;
    private float timeToFire = 0;
    public float fireRate;

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= timeToFire && Time.timeScale == 1f)
        {
            animator.SetBool("Attack", true);
            timeToFire = Time.time + 1 / fireRate;
            Invoke("Shoot", shootDelay);
            AudioManager.instance.Play("PlayerAttack");
        }
    }

    void Shoot()
    {
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
        animator.SetBool("Attack", false);
    }
    
}
