using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject[] ships;
	public static int selectedShip = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }
	
	private string scenePath = "SampleScene";

    // Update is called once per frame
    void Update()
    {
		if(Input.GetButtonDown("Horizontal")) {
			selectedShip = (selectedShip + 1) % ships.Length;
			UpdateUI();
		}
		
        if(Input.GetButtonDown("Submit")) {
			SceneManager.LoadScene(scenePath);
		}
    }
	
	void UpdateUI() {
		for(int i = 0; i < ships.Length; i++) {
			ships[i].SetActive(i == selectedShip);
		}
	}
}
