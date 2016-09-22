using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPlayer : MonoBehaviour {
    public string Bolivar;
    public string Miranda;
    public string Sucre;
    public string Zamora;

    public void SelectBolivar()
    {
        SceneManager.LoadScene(Bolivar);
    }

    public void SelectMiranda()
    {
        SceneManager.LoadScene(Miranda);
    }

    public void SelectSucre()
    {
        SceneManager.LoadScene(Sucre);
    }

    public void SelectZamora()
    {
        SceneManager.LoadScene(Zamora);
    }
}
