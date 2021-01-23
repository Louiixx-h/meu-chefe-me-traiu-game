using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Hero : MonoBehaviour
{
    public float moveSpeed;
    public float forceJump;
    public Joystick joy;
    public GameObject player;
    public bool isGround;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public ParticleSystem dust;
    public GameObject bullet;
    public Transform positionWeapon;
    public bool flip;
    
    private Vector2 direction;
    private Rigidbody2D rb;
    private Animator anim;
    private float horizontal;
    private PhotonView photonView;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        CheckGround();
    	Movement();
    }
    
    void Movement()
    {        
        horizontal = joy.Horizontal;
        if(horizontal >= 0.777 | horizontal <=-0.777){
            anim.SetInteger("transition", 1);
            Flip();
            rb.velocity = new Vector2(horizontal*moveSpeed*Time.deltaTime, rb.velocity.y);
        } else {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetInteger("transition", 0);
        }
    }
    
    public void Flip()
    {
        if(horizontal <=-0.777){
            Dust();
            transform.localScale = new Vector3(-1,1, 1);
            flip = true; 
        } else {
            Dust();
            transform.localScale = new Vector3(1,1, 1);
            flip = false;
        }
    }

    void CheckGround()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }

    public void Jump()
    {
        if (isGround == true)
        {
            Dust();
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);   
        }
    }

    public void Fire(){
        Instantiate(bullet, positionWeapon.position, positionWeapon.rotation);
    }

    void Dust()
    {
        dust.Play();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Enemy")
        {
            GetComponent<Life>().Damage();
        }
    }
}
