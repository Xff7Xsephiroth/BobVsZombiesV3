﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class HealthSystem : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public Slider healthBar;
    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
        }
    }

    void Update()
    {
        if (gameObject.tag == "Player")
        {
            healthBar.value = health;

            if (health < 1)
            {
                GetComponent<GameOverManager>().gameOver();
            }
        }
    }
}
