﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;
    private float moveVelocity; 

    public Transform groundCheck;
    public float grounsCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool doubleJumped;

    private Animator anim;

    public Transform firePoints;
    public GameObject bala;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        
	}

    void FixedUpdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, grounsCheckRadius, whatIsGround);
    }
	
	// Update is called once per frame
	void Update () {
//-----codigo para que salte----------------------------

        if (grounded)
        {
            doubleJumped = false;
        }

        anim.SetBool("Ground", grounded);
            
        if (Input.GetKeyDown (KeyCode.Space) && grounded)
        {
            jump();
            //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            jump();
            //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            doubleJumped = true; 
        }

        //------codigo para que camine----------------------------

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(7f, 7f, 1f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-7f, 7f, 1f);

        //----------disparar------------------

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bala, firePoints.position, firePoints.rotation);
        }
    }
    //-----funsion para saltar------------
    public void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}
