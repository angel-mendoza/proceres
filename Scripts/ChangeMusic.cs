using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

    public AudioClip musicaEntrada;
    public AudioClip musicaLevel;
    private AudioSource sourse;

	// Use this for initialization
	void Awake () {
        sourse = GetComponent<AudioSource>();
	}
	
    void OnLevelWasLoaded(int level)
    {
        if (level == 0 || level == 1)
        {
            sourse.clip = musicaEntrada;
            sourse.Play();
        }

        if (level > 1)
        {
            sourse.clip = musicaLevel;
            sourse.Play();
        }
    }
}
