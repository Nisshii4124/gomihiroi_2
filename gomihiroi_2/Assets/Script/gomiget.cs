using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomiget : MonoBehaviour
{
    GameObject gomiPre;

    // Use this for initialization
    void Start()
    {
        gomiPre = (GameObject)Resources.Load("otosugomi");
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeandScore.gomi != 0)
        {
            if (gomibako.gomisuteru == false)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    TimeandScore.gomi -= 1;
                    GameObject.Instantiate(gomiPre);
                }
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        // string label = " ";
        //if (TimeandScore.gomi <= TimeandScore.gomimax)
        //{
        //    if (other.gameObject.tag == "gomi")//tag「gomi」のついたオブジェクトにふれたら
        //    {

        //        if (Input.GetKey(KeyCode.UpArrow))
        //        {
        //            Destroy(other.gameObject);//オブジェクトを消す
        //            TimeandScore.gomi += 1;
        //        }
        //    }
        //}
        //if (other.gameObject.tag == "gomibako")//tag「gomibako」のついたオブジェクトにふれたら
        //{
        //    gomisuteru = true;
        //    if (Input.GetKeyDown(KeyCode.DownArrow))
        //    {
        //        sutetagomi = TimeandScore.gomi;
        //        TimeandScore.score += sutetagomi * scoreUp * 100;
        //        sutetagomi = 0;
        //        TimeandScore.gomi = 0;
        //    }
    }
    //else
    //{
    //    gomisuteru = false;
    //}
}