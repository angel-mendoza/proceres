using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour {

    //public int startingLives;
    private int lifeCounter;

    private Text theText;

    public GameObject gameOverScreen;
    public PlayerController player;

    public string mainMenu;

    public float waitAftherGameOver;

	// Use this for initialization
	void Start () {
        theText = GetComponent<Text>();

        lifeCounter = PlayerPrefs.GetInt("PlayerCurrentLives");

        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (lifeCounter < 1)
        {
            gameOverScreen.SetActive(true);
            player.gameObject.SetActive(false);
        }

        theText.text = "" + lifeCounter;

        if (gameOverScreen.activeSelf)
        {
            waitAftherGameOver -= Time.deltaTime;
        }

        if(waitAftherGameOver < 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
	}

    public void GiveLife()
    {
        lifeCounter++;
        PlayerPrefs.SetInt("PlayerCurrentLives", lifeCounter);
    }

    public void TakeLife()
    {
        lifeCounter--;
        PlayerPrefs.SetInt("PlayerCurrentLives", lifeCounter);
    }
}
