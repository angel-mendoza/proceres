using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private PlayerController player;

    public GameObject DeathParticle;
    public GameObject LiveParticle;

    public int pointPenaltyOnDeath;

    public float respawnDelay;

    public float gravityStore;

    private CameraController camara;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
        camara = FindObjectOfType<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RespawnPlayer(){
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(DeathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        camara.isFollowing = false;
        //gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
        //player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        //player.GetComponent<Rigidbody2D>().velocity =  Vector2.zero;
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        //player.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        player.transform.position = currentCheckPoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        camara.isFollowing = true;
        Instantiate(LiveParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}
