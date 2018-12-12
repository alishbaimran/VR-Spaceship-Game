using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Ship ship;
    public GameObject asteroidPrefab;
    public TextMesh scoreText;

    public float spawnDistance = 5f;
    public float spawnIncrement = 1f;

    private float spawnPointer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ship.transform.position.z > spawnPointer) {
            GameObject asteroidObject = Instantiate(asteroidPrefab);
            asteroidObject.transform.position = new Vector3(
                Random.Range(-2.3f, 2.3f),
                Random.Range(-2.3f, 2.3f),
               
                ship.transform.position.z + spawnDistance
                );

            spawnPointer = ship.transform.position.z + spawnIncrement;
        }
        int playerScore = Mathf.RoundToInt(ship.transform.position.z);
        if (playerScore < 0) {
            playerScore = 0;
        }
        scoreText.text = "Score: " + playerScore;
	}
}
