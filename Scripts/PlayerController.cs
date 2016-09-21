using UnityEngine;
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

    public float shotDelay;
    private float shotDelayCounter;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRigth;

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

        if (knockbackCount <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }else
        {
            if (knockFromRigth)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
            }

            if (!knockFromRigth)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, -knockback);
            }
            knockbackCount -= Time.deltaTime;
        }
       

        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(7f, 7f, 1f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-7f, 7f, 1f);

        //----------disparar------------------
        if (anim.GetBool("Disparo"))
        {
            anim.SetBool("Disparo", false);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bala, firePoints.position, firePoints.rotation);
            shotDelayCounter = shotDelay;
            anim.SetBool("Disparo", true);
        }

        //----regula que solo puede disparar cada segundo
        if (Input.GetKeyDown(KeyCode.Z))
        {
            shotDelayCounter -= Time.deltaTime;
            if (shotDelayCounter <= 0)
            {
                shotDelayCounter = shotDelay;
                Instantiate(bala, firePoints.position, firePoints.rotation);
            }
        }



        //--------ataque con la espada


            //if (anim.GetBool("Espada"))
        //{
        //    anim.SetBool("Espada", false);
        //}
        //if (Input.GetKey(KeyCode.X))
        //{
        //    anim.SetBool("Espada", true);
        //}




    }
    //-----funsion para saltar------------
    public void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}
