using UnityEngine;
using System.Collections;

public class PezController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int daño;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed);
    }

}