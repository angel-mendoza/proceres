using UnityEngine;
using System.Collections;

public class PezController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //rb.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed);
        //rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        rb.AddForce(new Vector2(0f, speed));

    }

}