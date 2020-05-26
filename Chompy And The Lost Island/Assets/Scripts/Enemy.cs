using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int xp = 5;

    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetHealth(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        healthBar.SetHealth(health);

        if (health <= 0)
        {
            AudioManager.instance.Play("EnemyDeath");
            Die();
            GameStatus.GetInstance().AddScore(xp);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
