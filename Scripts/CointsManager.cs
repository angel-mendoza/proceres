using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CointsManager : MonoBehaviour {

    public static int coints;

    Text text;

    private LifeManager lifeSystem;

    void Start()
    {
        lifeSystem = FindObjectOfType<LifeManager>();
        text = GetComponent<Text>();
        //coints = 0;
        coints = PlayerPrefs.GetInt("CurrentPlayerCoints");
    }

    void Update()
    {
        if (coints < 0)
            coints = 0;
        text.text = "" + coints;
        if (coints > 99)
        {
            lifeSystem.GiveLife();
            Reset();
        }
        
    }

    public static void AddCoints(int cointsToAdd)
    {
        coints += cointsToAdd;
        PlayerPrefs.SetInt("CurrentPlayerCoints", coints);
    }

    public static void Reset()
    {
        coints = 0;
        PlayerPrefs.SetInt("CurrentPlayerCoints", coints);
    }
}
