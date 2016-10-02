using UnityEngine;
using System.Collections;

public class ComboAtackManager : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -GetComponent<Rigidbody2D>().velocity.y);

	}
}
