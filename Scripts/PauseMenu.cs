using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public string levelSelect;
    public string mainMenu;

    public bool pantallaDeMision;
    public bool isPaused;

    public GameObject pauseMenuCanvas;
    public GameObject pantallaMision;


    // Update is called once per frame
    void Update () {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            isPaused = !isPaused;
        }

        if (pantallaDeMision == true)
        {
            pantallaMision.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pantallaDeMision = false;
                pantallaMision.SetActive(false);
            }
        }
    }

    public void Resumen()
    {
        isPaused = false;
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void Quit()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void Mision()
    {
        pantallaDeMision = true;
    }
}
