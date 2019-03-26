using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsGeneratorScript : MonoBehaviour
{
    public Font font;
    public GameObject obstacle;

    void Start()
    {
        float delayTime = 0;
        float timeSpan = 2;

        //Повторяющтйся вызов метода AddObstacle через delayTime секунд каждые timeSpan сек
        InvokeRepeating("AddObstacle", delayTime, timeSpan);
    }

    void AddObstacle()
    {
        Instantiate(obstacle);
    }

    void Update()
    {
        if (BirdScript.gameOver)
        {
            CancelInvoke();
        }

    }
}
