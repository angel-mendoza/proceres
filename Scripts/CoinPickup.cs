using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {
    public int cointsToAdd;
    public int pointsToAdd;
    public AudioSource coinSoundsEffect;

    public GameObject moneda;

    void Start()
    {
        moneda = GetComponent<GameObject>();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
            return;

        ScoreManager.AddPoints(pointsToAdd);
        CointsManager.AddCoints(cointsToAdd);
        coinSoundsEffect.Play();
        Destroy(gameObject); 
    }
}
