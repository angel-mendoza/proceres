using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
    public static int playerHealth;


   public int maxPlayerHealth;

    //Text text;
    public Slider healthBar;

    private LevelManager levelmanager;

    public bool isDead;

    private LifeManager lifesystem;

    private TimeManager theTime;

    // Use this for initialization
    void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
        // text = GetComponent<Text>();
        healthBar = GetComponent<Slider>();

        // playerHealth = maxPlayerHealth;
        playerHealth = PlayerPrefs.GetInt("PlayerCurrentHealth");

        theTime = FindObjectOfType<TimeManager>();

        isDead = false;

        lifesystem = FindObjectOfType<LifeManager>();
	}
	
	// Update is called once per frame
	void Update () {

        if (playerHealth <= 0 && !isDead)
        {
            playerHealth = 0;
            levelmanager.RespawnPlayer();
            lifesystem.TakeLife();
            isDead = true;
            theTime.ResetTiem();
        }

        if (playerHealth > maxPlayerHealth)
        {
            playerHealth = maxPlayerHealth;
        }
        // text.text = "" + playerHealth;
        healthBar.value = playerHealth;
	}

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
        PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);
    }

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
        PlayerPrefs.GetInt("PlayerMaxHealth");
        PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);
    }

    public void KillPlayer()
    {
        playerHealth = 0;
    }
}
