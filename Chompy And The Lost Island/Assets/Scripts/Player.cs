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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TakeDamage(20);
        }
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
