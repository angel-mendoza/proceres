using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string starLeverl;

    public void NewGame()
    {
        SceneManager.LoadScene(starLeverl);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
