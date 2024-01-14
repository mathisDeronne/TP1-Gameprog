using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    
	public Transform boundTL, boundBR;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 10f;
		Vector3 direction = new Vector3(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical"),
			0.0f
		);
		
		Vector3 newPosition = transform.position + direction * speed * Time.fixedDeltaTime;
		
		if(newPosition.x < boundTL.position.x)
			newPosition.x = boundTL.position.x;
		if(newPosition.x > boundBR.position.x)
			newPosition.x = boundBR.position.x;
		if(newPosition.y > boundTL.position.y)
			newPosition.y = boundTL.position.y;
		if(newPosition.y < boundBR.position.y)
			newPosition.y = boundBR.position.y;
		
		transform.position = newPosition;
		
		
		
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed * Time.fixedDeltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, speed * Time.fixedDeltaTime, 0f);
        }*/
    }
	
	void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
		SpawnPrefab.i.EndGame();
		Destroy(gameObject);
    }
}
