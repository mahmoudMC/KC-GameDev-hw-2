using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    Rigidbody2D rb;
    int speed = 3;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float ver = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(0, ver * speed);
    }
}
