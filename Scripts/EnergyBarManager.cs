using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyBarManager : MonoBehaviour {

    public Slider energybar;
    public float tiempo;

	// Use this for initialization
	void Start () {

        energybar = GetComponent<Slider>();

	}
	
	// Update is called once per frame
	void Update () {

        tiempo += Time.deltaTime;
        energybar.value = tiempo;
	}
}
