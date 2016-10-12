using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
    public GameObject loadingImage;
    public string level;

    public void LoadScene(string level)
    {
        loadingImage.SetActive(true);
        //Application.LoadLevel(level);
        SceneManager.LoadScene(level);
        
    }

}
