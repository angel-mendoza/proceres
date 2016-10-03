using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

    public LevelManager levelManager;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckPoint = gameObject;
            Debug.Log("Activated Checkpoint " + transform.position);
            anim.SetBool("activado", true);
        }
    }
}
