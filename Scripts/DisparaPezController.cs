using UnityEngine;
using System.Collections;

public class DisparaPezController : MonoBehaviour {
    public Transform firePoints;
    public GameObject pez;
    GameObject pezclon;
    public float tiempo;
    public float tiempoDisparo;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tiempo += Time.deltaTime;
        if (tiempo >= tiempoDisparo)
        {
            pezclon = Instantiate(pez, firePoints.transform.position, Quaternion.identity) as GameObject;
            tiempo = 0;
        }
       
	}
}
