using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public static WASDController Instance; //player is also a singleton
    
    Rigidbody2D rb2d; //2D physics

    public float forceAmount = 60; //control the amount of force applied to the rb

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject); //Singleton, checking if the instance exists, don't delete this version of the instance
            Instance = this;
        }
        else
        {
            Destroy(gameObject); //delete any other versions that exist so there's no complications of overlapping instances throughout levels
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //get the rb of the 2D game object this script is attached to 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(Vector2.up * forceAmount); //adding force in direction UP by multiplying the vector position times amount of force
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * forceAmount);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddForce(Vector2.down * forceAmount);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * forceAmount);
        }

        rb2d.velocity *= 0.999f; //controlling the velocity so that it doesn't get overscaled

    }
}
