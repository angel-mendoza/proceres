using UnityEngine;
using System.Collections;

public class BalaController : MonoBehaviour {

    public float speed;
    public PlayerController player;

    public GameObject enemyDeathtEffect;

    public int pointsForKill;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        if ( player.transform.localScale.x < 0)
        {
            speed = -speed;
        }
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(enemyDeathtEffect, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
