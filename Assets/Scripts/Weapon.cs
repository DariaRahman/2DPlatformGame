using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{   
    Rigidbody2D rb;
    public Transform shotpos;
    public GameObject Bullet;
    public GameObject shotbtn;
    
    private float TimeBtwShots;
    public float StartTimeBtwShots;

    float PosShotBtn;

    private GameObject player;
    

    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        PosShotBtn = shotbtn.transform.position.y;
    }

    void Update()
    {   
        if (TimeBtwShots <= 0)
        {
            if(Input.GetKey(KeyCode.Space))
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
