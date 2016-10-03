using UnityEngine;
using System.Collections;

public class TutorialController : MonoBehaviour {
    public GameObject pantallaDeTutorial;
    public bool contacto;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (contacto == true)
        {
            pantallaDeTutorial.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            desactivarTutorial();
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            contacto = true;
        }
    }

    void desactivarTutorial()
    {
        contacto = false;
        pantallaDeTutorial.SetActive(false);
    }
}
