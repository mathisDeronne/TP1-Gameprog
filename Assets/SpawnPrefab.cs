using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject spawnPrefab;
	public Transform spawnPoint1, spawnPoint2;
	public GameObject[] ships;
	
	public float nbAsteroidsPerSecond = 1.0f;
	private float timeSinceLastAsteroid = 0.0f;
	
	public GameObject deathScreen;
	
	public static SpawnPrefab i;
	
    // Start is called before the first frame update
    void Start()
    {
		i = this;
		deathScreen.SetActive(false);
		
		for(int j = 0; j < ships.Length; j++) {
			if(j != MainMenu.selectedShip)
				Destroy(ships[j]);
		}
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		timeSinceLastAsteroid += Time.fixedDeltaTime;
		
		if(timeSinceLastAsteroid > 1.0f/nbAsteroidsPerSecond) {
			SpawnAsteroid();
			timeSinceLastAsteroid = 0.0f;
		}
    }
	
	void SpawnAsteroid() {
		float t = Random.Range(0.0f, 1.0f);
		Vector3 pos = Vector3.Lerp(spawnPoint1.position, spawnPoint2.position, t);
		
        GameObject ball = Instantiate(spawnPrefab, pos, Quaternion.identity);
	}
	
	public void EndGame() {
		deathScreen.SetActive(true);
	}
}
