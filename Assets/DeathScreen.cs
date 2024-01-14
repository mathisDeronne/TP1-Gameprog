using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
	public float timeToReload = 2.5f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToReload -= Time.deltaTime;
		
		if(timeToReload <= 0.0f) {
			SceneManager.LoadScene("MainMenu");
		}
    }
}
