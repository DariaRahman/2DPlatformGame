using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{   
    Animator anim;
    Rigidbody2D rb; 
    public GameObject Hero;
    public GameObject HealthBar1;
    public GameObject HealthBar2;
    public GameObject Gun;

    
    bool flipbot;
    float run;
    

    [Header("Health")]
    [SerializeField] private int Health;
    [SerializeField] private Image HealthBar;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent <Animator>();
    }


    void Update()
    {   
          
        if(Hero.transform.position.x<transform.position.x){
            flipbot = false;
            Flip1();
        }

        if (Hero.transform.position.x>transform.position.x){
            flipbot = true;
            Flip1();
        }

        if (Hero.transform.position.x>transform.position.x+1f){
            flipbot = true;
            run = +0.5f;
            Flip1();

        }
        else if (Hero.transform.position.x<transform.position.x-1f){
            flipbot = false;
            run = -0.5f;
            Flip1();
         
        }
        else {
            run = 0f;
        }
        rb.velocity = new Vector2 (run, rb.velocity.y); 
    }
       

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

    void Flip1(){
        if(flipbot == true ){
            HealthBar1.transform.position = new Vector3 (transform .position .x+0.0f, transform .position .y+1f, -1.5f);
            HealthBar2.transform.position = new Vector3 (transform .position .x+0.0f, transform .position .y+1f, -1.5f);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
         
        }
        if (flipbot == false){
            HealthBar1.transform.position = new Vector3 (transform .position .x+0.0f, transform .position .y+1f, -1.5f);
            HealthBar2.transform.position = new Vector3 (transform .position .x+0.0f, transform .position .y+1f, -1.5f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
           
        }
    }



}
