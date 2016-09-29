using UnityEngine;
using System.Collections;

public class LevelSelectManeger : MonoBehaviour {
    public string[] levelTags;

    public GameObject[] puertas;

    public GameObject[] locks;

    public bool[] levelUnLocked;
    // Use this for initialization
    void Start() {

        for (int i = 0; i < levelTags.Length; i++)
        {
            if (PlayerPrefs.GetInt(levelTags[i]) == null)
            {
                levelUnLocked[i] = false;
            }
            else if (PlayerPrefs.GetInt(levelTags[i]) == 0)
            {
                levelUnLocked[i] = false;

            }

            else
            {
                levelUnLocked[i] = true;
            }

            if (levelUnLocked[i])
            {
                locks[i].SetActive(false);
                
            }

            if (!levelUnLocked[i])
            {
                puertas[i].GetComponent<Collider2D>().enabled = false;
            }
        }
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
