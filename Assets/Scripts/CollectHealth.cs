using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectHealth : MonoBehaviour 
{
    
    [Header("Health")]
    [SerializeField] private int Health;
    [SerializeField] private Image HealthBar;

    private void GetHealth()
    {
        Health += 20;

        HealthBar.fillAmount = Health * 0.01f;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Health"))
        {
            Destroy(collision.gameObject);
            GetHealth();

        }
    }
}

