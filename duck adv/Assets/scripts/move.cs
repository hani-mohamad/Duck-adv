using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move: MonoBehaviour
{

    public float movespeed = 4f; // how fast

    public Rigidbody2D rb;  // shortcut for rigidbody

    Vector2 Movement;     // storing the x and y moevment in a vector2

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal"); // storing the x in the vector2
       
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * movespeed * Time.fixedDeltaTime);

    }

}

