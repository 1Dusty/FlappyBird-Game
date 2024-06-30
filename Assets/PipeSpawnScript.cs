using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float Spawnrate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<Spawnrate)
        {
            timer = timer +Time.deltaTime;
        }
        Instantiate(Pipe, transform.position, transform.rotation);
    }
}
