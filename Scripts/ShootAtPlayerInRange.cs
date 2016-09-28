using UnityEngine;
using System.Collections;

public class ShootAtPlayerInRange : MonoBehaviour {

    public float playerRange;
    public GameObject enemyBala;

    public PlayerController thePlayer;

    public Transform lauchPoints;

    public float waitBetweenShoot;

    private float shootCounter;

	// Use this for initialization
	void Start () {

        thePlayer = FindObjectOfType<PlayerController>();

        shootCounter = waitBetweenShoot;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.DrawLine(new Vector3(transform.position.x + playerRange, transform.position.y + 15, transform.position.z), new Vector3(transform.position.x - playerRange, transform.position.y + 15, transform.position.z));
        Debug.DrawLine (new Vector3 (transform.position.x - playerRange, transform.position.y + 15 , transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y + 15 , transform.position.z));
        shootCounter -= Time.deltaTime;

        if (transform.localScale.x < 0 && thePlayer.transform.position.x < transform.position.x && thePlayer.transform.position.x < transform.position.x + playerRange && shootCounter < 0)
        {
           
            Instantiate(enemyBala, lauchPoints.position, lauchPoints.rotation);
            shootCounter = waitBetweenShoot;
        }

        if (transform.localScale.x > 0 && thePlayer.transform.position.x > transform.position.x && thePlayer.transform.position.x > transform.position.x - playerRange && shootCounter < 0)
        {
            
            Instantiate(enemyBala, lauchPoints.position, lauchPoints.rotation);
            shootCounter = waitBetweenShoot;
        }
    }

}
