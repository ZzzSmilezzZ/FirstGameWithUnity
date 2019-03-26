using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public static bool gameOver = false;
    private Rigidbody2D birdObj;

    void Start()
    {
        birdObj = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BirdScript.gameOver = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (BirdScript.gameOver == false)
            {
                birdObj.velocity = Vector2.zero;
                birdObj.AddForce(new Vector2(0, 200));
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                BirdScript.gameOver = false;
            }
        }
    }
}
