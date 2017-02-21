using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{
    int sutetagomi;
    int scoreUp = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sutetagomi == 0)
        {
            scoreUp = 1;
        }
        else if (sutetagomi <= 5)
        {
            scoreUp = 3;

            if (sutetagomi <= 4)
            {
                scoreUp = 2;

                if (sutetagomi <= 2)
                {
                    scoreUp = 1;
                }
            }
        }

    }

    public void OnTriggerStay(Collider other)
    {
        // string label = " ";
        if (TimeandScore.gomi <= TimeandScore.gomimax)
        {
            if (other.gameObject.tag == "gomi")//tag「gomi」のついたオブジェクトにふれたら
            {

                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Destroy(other.gameObject);//オブジェクトを消す
                    TimeandScore.gomi += 1;
                }
            }
        }
        if (other.gameObject.tag == "gomibako")//tag「gomibako」のついたオブジェクトにふれたら
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                sutetagomi = TimeandScore.gomi;
                TimeandScore.score += sutetagomi * scoreUp * 100;
                sutetagomi = 0;
                TimeandScore.gomi = 0;
            }
        }
    }
}