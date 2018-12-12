using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    private float lifetime = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;

        if (lifetime < 0) {
            Destroy(gameObject);
        }
	}
}
