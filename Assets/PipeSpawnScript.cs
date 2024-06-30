using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float Spawnrate = 2;
    public float HeightOffset = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<Spawnrate)
        {
            timer = timer +Time.deltaTime;
        } 
        else
        {
         SpawnPipe();   
         timer = 0;
        }
        
    }
    
    void SpawnPipe()
    {
        float LowestPoint = transform.position.y - HeightOffset;
        float HighestPoint = transform.position.y + HeightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint),0), transform.rotation);
    }
}
