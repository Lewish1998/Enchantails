
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float jump;

    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D)) {
            rb.velocity = Vector2.right * speed;
        }
           if (Input.GetKey(KeyCode.A)) {
            rb.velocity = Vector2.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.up * jump;
        }

        
    }
}
