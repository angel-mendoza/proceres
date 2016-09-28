using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public float startingTime;
    private float countingTime; 
    private Text theText;

    private HealthManager theHealth;

    //public GameObject gameOverScreen;
    //public PlayerController player;

    // Use this for initialization
    void Start () {

        countingTime = startingTime;
        theText = GetComponent<Text>();

        theHealth = FindObjectOfType<HealthManager>();
       // player = FindObjectOfType<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {

        countingTime -= Time.deltaTime;

        if (countingTime < 1)
        {
            //gameOverScreen.SetActive(true);
            //player.gameObject.SetActive(false);
            theHealth.KillPlayer();
            
        }

        theText.text = "" + Mathf.Round(countingTime);

	}

    public void ResetTiem()
    {
        countingTime = startingTime;
    }
}
