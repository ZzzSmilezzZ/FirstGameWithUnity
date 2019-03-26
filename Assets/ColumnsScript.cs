using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsScript : MonoBehaviour
{
    Rigidbody2D colsRB;

    void Start()
    {
        float velocityX = -6;

        colsRB = GetComponent<Rigidbody2D>();
        colsRB.velocity = new Vector2(velocityX, 0);

        //random cols position
        var pos = colsRB.transform.position;
        pos.y -= (Random.value * 6);

        colsRB.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdScript.gameOver) colsRB.velocity = Vector2.zero;
    }
}
