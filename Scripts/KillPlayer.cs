﻿using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;
    private LifeManager lifesystem;

    // Use this for initialization
    void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        lifesystem = FindObjectOfType<LifeManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.RespawnPlayer();
            lifesystem.TakeLife();
        }
    }
}
