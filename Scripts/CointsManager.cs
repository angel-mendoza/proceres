using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CointsManager : MonoBehaviour {

    public static int coints;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        coints = 0;
    }

    void Update()
    {
        if (coints < 0)
            coints = 0;
        text.text = "" + coints;
    }

    public static void AddCoints(int cointsToAdd)
    {
        coints += cointsToAdd;
    }

    public static void Reset()
    {
        coints = 0;
    }
}
