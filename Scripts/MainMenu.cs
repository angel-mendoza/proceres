using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string starLeverl;

    public int playerLive;

    public int playerHealth;

    public string level1Tag;

    public void NewGame()
    {
        
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLive);

        PlayerPrefs.SetInt("CurrentPlayerCoints", 0);

        PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);

        PlayerPrefs.SetInt("PlayerMaxHealth", playerHealth);

        PlayerPrefs.SetInt(level1Tag, 1);

        SceneManager.LoadScene(starLeverl);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
