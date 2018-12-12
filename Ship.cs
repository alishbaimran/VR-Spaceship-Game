using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour {

    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;
	}

    void OnTriggerEnter (Collider otherCollider)  {
       if (otherCollider.tag == "Obstacle")  {
            SceneManager.LoadScene (SceneManager.GetActiveScene().name);


        }
    }
}
