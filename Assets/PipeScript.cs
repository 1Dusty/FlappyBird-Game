using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour  
{
    public float Movespeed = 5;
    public float Deadzone = -6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Movespeed) * Time.deltaTime;

        if(transform.position.x < Deadzone)
        {
            Destroy(gameObject);
        }
    }
}
