using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class heroscript : MonoBehaviour
{   

    Animator anim;
    public Rigidbody2D rb; 
    public GameObject gun1;
    public LayerMask Ground;
    public Transform checkPosition;
    public GameObject HealthBar1;
    public GameObject HealthBar2;

    public float checkRadius;
    public float jumpforce;
    public bool isGrounded = false;
    bool whenlook;
    float run;

    [Header("Health")]
    [SerializeField] 
    public int Health;
    [SerializeField] 
    public Image HealthBar;

    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent <Animator>();
    }


    void Update(){

        isGrounded = Physics2D.OverlapCircle(checkPosition.position, checkRadius, Ground);

        if(Input.GetKeyDown(KeyCode.W) && isGrounded == true){//(PosJumpBtn != jumpbtn.transform.position.y && isGrounded == true){
            rb.AddForce (transform.up * jumpforce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        
        if(Input.GetKey(KeyCode.A)){
            run = -3f;
            whenlook = false;
            Flip();
            anim.SetBool ("Run", true);
        }

        else if(Input.GetKey(KeyCode.D)){
            run = 3f;
            whenlook = true;
            Flip();
            anim.SetBool ("Run", true);
        }

        else{
            run = 0f;
            anim.SetBool("Run", false);
        }

        if (transform.position.y < -20f){
            GetDead();
            Destroy(gameObject);

        }

        rb.velocity = new Vector2 (run, rb.velocity.y); 

        
    } 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GetDamage();
        }
        if (other.gameObject.tag == "Damage")
        {
            GetDamage();
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Contains("Shot enemy"))
        {
            GetDamage();
        }
    }

    void Flip(){
        if(whenlook == true ){
            gun1.transform.position = new Vector3 (transform .position .x-0.00f, transform .position .y-0.27f, -1.2f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (whenlook == false){
            gun1.transform.position = new Vector3 (transform .position .x-0.00f, transform .position .y-0.27f, -1.2f);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
    

    private void GetDamage()
    {
        Health -= 10;

        HealthBar.fillAmount = Health * 0.01f;

        if (Health <= 0)
        {
            Destroy(gameObject);

        }

    }

    private void GetDead()
    {
        Health -=100;
        HealthBar.fillAmount = Health * 0.01f;

    }


}