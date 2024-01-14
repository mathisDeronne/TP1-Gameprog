using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFastBoy : Ship
{
	Vector3 momentum = new Vector3(0.0f, 0.0f, 0.0f);
	
	public float turnSpeed = 120.0f;
	public float accel = 12.0f;
	public float brake = 8.0f;
	
	
	void FixedUpdate()
    {
		
		float inputX = Input.GetAxis("Horizontal");
		transform.Rotate(new Vector3(0.0f, 0.0f, inputX * -turnSpeed * Time.fixedDeltaTime));
		
		
		Vector3 direction = transform.up;
		
		float a = 0.0f;
		float inputY = Input.GetAxis("Vertical");
		
		if(inputY > 0.0f)
			a = inputY * accel;
		if(inputY < 0.0f)
			a = inputY * brake;
		
		momentum += direction * a * Time.fixedDeltaTime;
		
		
		transform.position += momentum * Time.fixedDeltaTime;
		StayInBounds();
    }
}
