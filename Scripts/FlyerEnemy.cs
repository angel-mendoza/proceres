﻿using UnityEngine;
using System.Collections;

public class FlyerEnemy : MonoBehaviour {
    private PlayerController thePlayer;
    public float moveSpeed;
    public float playerRange;

    public LayerMask playerLayer;
    public bool playerInRange;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {

        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);

        if (playerInRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, moveSpeed * Time.deltaTime);
        }
       
	}

    void OnDrawGizmosSelected()
    {
 
        Gizmos.DrawSphere(transform.position, playerRange);
        if (thePlayer.transform.position.x < transform.position.x)
        {
            GetComponent<Transform>().localScale = new Vector3(20f, 20f, 1f);
        }else
        {
            GetComponent<Transform>().localScale = new Vector3(-20f, 20f, 1f);
        }
    }
}
