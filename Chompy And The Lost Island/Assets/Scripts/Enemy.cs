using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int xp = 5;

    public HealthBar healthBar;
    public Animator animator;
    BeetleAI beetleMove;

    void Start()
    {
        beetleMove = gameObject.GetComponent<BeetleAI>();
        healthBar.SetHealth(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        healthBar.SetHealth(health);

        if (health <= 0)
        {
            beetleMove.enabled = !beetleMove.enabled;
            AudioManager.instance.Play("BeetleDeath");
            GameStatus.GetInstance().AddScore(xp);
            //Invoke("Die", 2.5f);
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
