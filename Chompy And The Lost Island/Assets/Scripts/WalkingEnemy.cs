using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : Enemy
{
    public int damage = 25;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<Player>().TakeDamage(damage);
        }
    }
}
