using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float speed = 1f;
        transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
    }
}
