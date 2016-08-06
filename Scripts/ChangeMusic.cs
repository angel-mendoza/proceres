using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

    public AudioClip leve2Music;
    private AudioSource sourse;

	// Use this for initialization
	void Awake () {
        sourse = GetComponent<AudioSource>();
	}
	
    void OnLevelWasLoaded(int level)
    {
        if (level != 0)
        {
            sourse.clip = leve2Music;
            sourse.Play();
        }
    }
}
