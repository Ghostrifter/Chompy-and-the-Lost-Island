using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetHealth(health);
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        healthBar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        AudioManager.instance.Play("GameOver");
        FindObjectOfType<GameOverMenu>().GameOver();
        Destroy(gameObject);
    }
}
