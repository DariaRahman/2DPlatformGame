using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemyfly : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int Health;
    [SerializeField] private Image HealthBar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            GetDamage();
        }
    }

    private void GetDamage()
    {
        Health -= 20;

        HealthBar.fillAmount = Health * 0.01f;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }

    }

}
