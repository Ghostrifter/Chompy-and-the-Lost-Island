using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMove : MonoBehaviour
{
    public float speed;
    public int damage = 40;
    public Rigidbody rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Enemy EnemyHealth = hitInfo.GetComponent<Enemy>();
        if (EnemyHealth != null)
        {
            EnemyHealth.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
