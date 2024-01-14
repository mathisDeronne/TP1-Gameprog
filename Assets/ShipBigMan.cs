using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBigMan : Ship
{
    public float speed = 10f;
	
    void FixedUpdate()
    {
		Vector3 direction = new Vector3(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical"),
			0.0f
		);
		
		transform.position += direction * speed * Time.fixedDeltaTime;
		StayInBounds();
    }
}
