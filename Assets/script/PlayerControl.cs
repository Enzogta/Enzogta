using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static bool GameOver=false;
    float horizontal;
    float vertical;
    public float speed;
    public float jumpForce;
    Rigidbody2D body;
    public LayerMask LayerGround;
    public bool isGround;
    private bool jumpp=false;
    private int jump = 0;
    private SpriteRenderer _renderer;
    private Animator _Animator;


    public Transform groundcheck;

    void Start()
    {
        _Animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>(); 

        //transform.position=new Vector3(0f,0f,0f);
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGround = Physics2D.OverlapCircle(groundcheck.position, 0.15f, LayerGround);

        horizontal=Input.GetAxis("Horizontal");
        vertical=Input.GetAxis("Vertical");
        transform.position = new Vector2((horizontal*speed)+transform.position.x,transform.position.y);  

        if (Input.GetKeyDown(KeyCode.Space) && isGround && !jumpp){
            body.AddForce (new Vector2(0,jumpForce));
            //_Animator.SetInteger("estado",2);
            jumpp = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space)&& jumpp){
            body.AddForce (new Vector2(0,jumpForce));
            jumpp = false;
            //_Animator.SetInteger("estado",3);
        }

        if (Input.GetAxisRaw("Horizontal")>0){
            _renderer.flipX = false;
        }
        else if(Input.GetAxisRaw("Horizontal")<0){
             _renderer.flipX = true;          
        }

        
        if(Input.GetAxisRaw("Horizontal") == 0 && !isGround){
            //_Animator.SetInteger("estado",0);
        }
        if((Input.GetAxisRaw("Horizontal")>0 || Input.GetAxisRaw("Horizontal")<0) && !isGround){
            //_Animator.SetInteger("estado",1);
        } 
        
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="game_over")
        {
            GameOver=true;
        }
        else{
            GameOver=false;
        }
        if(other.tag=="fruta")
        {
            GameManager.pontos++;
        }
        if(other.tag == "Portal_1"){
            transform.position = new Vector3(-27.8f , 6f ,-6.26f);
        }
    }

   
}
