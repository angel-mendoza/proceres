using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyBarManager : MonoBehaviour {

    public Slider energybar;
    public float tiempo;
    public float tiempoEspera;
    public bool dispararCombo;
    

	// Use this for initialization
	void Start () {

        energybar = GetComponent<Slider>();
        dispararCombo = false;

	}
	
	// Update is called once per frame
	void Update () {
        energybar.maxValue = tiempoEspera;
        tiempo += Time.deltaTime;
        energybar.value = tiempo;

        if (tiempo >= tiempoEspera)
        {
            dispararCombo = true;
        }
        
	}
}
