using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{

    public int sutetagomi;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
       // string label = " ";
        if (TimeandScore.gomi <= TimeandScore.gomimax)
        {
            if (other.gameObject.tag == "gomi")//tag「gomi」のついたオブジェクトにふれたら
            {
<<<<<<< HEAD
                Destroy(other.gameObject);//オブジェクトを消す
                TimeandScore.gomi += 1;
                label = "ゴミを拾うよ～";
                GUI.TextField(new Rect(10, 10, 100, 100), label);
=======
                if (Input.GetKey(KeyCode.B))
                {
                    Destroy(other.gameObject);//オブジェクトを消す
                    TimeandScore.gomi += 1;
                  //  label = "ゴミを拾うよ～";
                }
               // GUI.TextField(new Rect(10, 10, 100, 100), label);
>>>>>>> f0e3afbd2f1cec08ad9155f42ac88c16b95fb2b2
            }
        }
        if (other.gameObject.tag == "gomibako")//tag「gomibako」のついたオブジェクトにふれたら
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                sutetagomi = TimeandScore.gomi;
                TimeandScore.score += sutetagomi * 100;
                sutetagomi = 0;
                TimeandScore.gomi = 0;
            }
        }
    }
    
}
