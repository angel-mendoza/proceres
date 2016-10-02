using UnityEngine;
using System.Collections;

public class ComboAtackManager : MonoBehaviour {

    public float speed;
    public int daño;
    public PlayerController player;


    // Use this for initialization
    void Start()
    {

        player = FindObjectOfType<PlayerController>();

        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
            
        }
    }
    void Update()
    {


        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealthManager>().giveDamage(daño);
        }
          
        
    }

    
    public void disparar()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }
    
}
