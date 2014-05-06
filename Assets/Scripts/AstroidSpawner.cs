using UnityEngine;
using System.Collections;

public class AstroidSpawner : MonoBehaviour {

	public float delayBetweenSpawning = 0.5f;
	public GameObject[] asteroidArray;
	public Transform[] spawnLocationsArray;

	// Use this for initialization
	void Start () {
		Invoke ("CreateAsteroid", 2.5f);
	}

	void CreateAsteroid()
	{
		int randomAsteroid = Random.Range(0, asteroidArray.Length);
		int randomSpawnPoint = Random.Range(0, spawnLocationsArray.Length);

		Instantiate(asteroidArray[randomAsteroid], 
		            spawnLocationsArray[randomSpawnPoint].position,
		            spawnLocationsArray[randomSpawnPoint].rotation);


		Invoke ("CreateAsteroid", delayBetweenSpawning);
	}
}
