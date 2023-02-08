using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlay1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPos;

    private float movement;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if(isPlay1)
        {
            movement = Input.GetAxisRaw("Vertical");
            //flip here
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
