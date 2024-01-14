using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    
	public float timeout = 14.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 1.25f;
        transform.position -= new Vector3(0f, speed * Time.fixedDeltaTime, 0f);
		
		timeout -= Time.fixedDeltaTime;
		if(timeout <= 0) {
			Destroy(gameObject);
		}
    }
	
	void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }
}
