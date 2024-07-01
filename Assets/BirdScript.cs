using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float Flapstrength;
    public LogicManager logic;
    public bool GameActive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GameActive)
        {
            myRigidbody.velocity = Vector2.up *Flapstrength ;
        }
        if (transform.position.y > 3 || transform.position.y < -3)
        {
            logic.GameOver();
            GameActive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        GameActive = false;
    }
}
