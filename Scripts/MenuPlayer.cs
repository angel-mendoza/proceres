using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPlayer : MonoBehaviour {
    public string Bolivar;
    public string Miranda;
    public string Sucre;
    public string Zamora;

    //--
    public GameObject loadingImage;
    //--

    public void SelectBolivar()
    {
        loadingImage.SetActive(true);
        SceneManager.LoadSceneAsync(Bolivar);
    }

    public void SelectMiranda()
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(Miranda);
    }

    public void SelectSucre()
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(Sucre);
    }

    public void SelectZamora()
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(Zamora);
    }
}
