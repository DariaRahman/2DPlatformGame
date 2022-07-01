using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletenemy : MonoBehaviour
{   
    Rigidbody2D rb;
    public float speed;

    
    void Start()
    {   
        
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * -speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("platform") || collision.name.Contains("Platform") || collision.name.Contains("Damage") ||  collision.name.Contains("GameObject")) 
        {
            Destroy(gameObject);
        }
        
    }

}

