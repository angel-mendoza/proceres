using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
    public static int playerHealth;


   public int maxPlayerHealth;

    Text text;

    private LevelManager levelmanager;

    public bool isDead;

    private LifeManager lifesystem;

    // Use this for initialization
    void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();

        // playerHealth = maxPlayerHealth;
        playerHealth = PlayerPrefs.GetInt("PlayerCurrentHealth");

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
        }

        text.text = "" + playerHealth;
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
}
