using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeandScore : MonoBehaviour
{
    public static int score = 0;
    public static int gomi = 0;
    public static int gomimax = 4;

    public Text gomiLabel;
    public Text scoreLabel;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = string.Format("スコア {0:0000}", score);

        gomiLabel.text = string.Format("ゴミの数 {0}/5", gomi);
    }
}
