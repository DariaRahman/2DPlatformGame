using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponEnemy : MonoBehaviour
{   
    Rigidbody2D rb;
    public Transform shotpos;
    public GameObject Bullet;
    public GameObject Hero;
    
    private float TimeBtwShots;
    public float StartTimeBtwShots;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        if (TimeBtwShots <= 0)
        {
            if(Hero.transform.position.x<transform.position.x)
            {  
                Instantiate (Bullet, shotpos.transform.position, transform.rotation);
                TimeBtwShots = StartTimeBtwShots;
            }
        }   
        else 
        {
            TimeBtwShots -= Time.deltaTime;
        }
        
       
    }
}
