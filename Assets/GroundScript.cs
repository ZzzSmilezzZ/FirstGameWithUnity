using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public float groundHorizontalLength;
    private BoxCollider2D groundCollider;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-6, 0);
    }

    public void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdScript.gameOver) rb2d.velocity = Vector2.zero;

        if (transform.position.x < -groundHorizontalLength)
        {
            Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
            transform.position = (Vector2)transform.position + groundOffSet;
        }
    }
}
