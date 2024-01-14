using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
	public Transform boundTL, boundBR;
	
	void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
		SpawnPrefab.i.EndGame();
		Destroy(gameObject);
    }
	
	protected void StayInBounds() {
		Vector3 newPosition = transform.position;
		
		if(newPosition.x < boundTL.position.x)
			newPosition.x = boundTL.position.x;
		if(newPosition.x > boundBR.position.x)
			newPosition.x = boundBR.position.x;
		if(newPosition.y > boundTL.position.y)
			newPosition.y = boundTL.position.y;
		if(newPosition.y < boundBR.position.y)
			newPosition.y = boundBR.position.y;
		
		transform.position = newPosition;
	}
}
