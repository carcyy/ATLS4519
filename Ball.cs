using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPos;

    void Start()
    {
        Move();
    }

    void Update()
    {

    }

    private void Move()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2((speed* x), (speed * y));
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
        Move();
    }
}
