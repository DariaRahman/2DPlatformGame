using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour{

    public float speed;
    Rigidbody2D rb;
    
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("platform") || collision.name.Contains("Platform") || collision.name.Contains("Damage") || collision.name.Contains("Enemy"))
        {
            Destroy(gameObject);
        }

    }

}