﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Sutamina : MonoBehaviour {

    public float Dash;    //ダッシュの倍率
    public bool DashFlag; //ダッシュできるかどうか

    public float sutamina;//スタミナ
    Slider SUTAMINA;

    public float ReCaver;
    public bool ReCaverOK;

    testmove player;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        SUTAMINA = GameObject.Find("Slider").GetComponent<Slider>();        


        sutamina = SUTAMINA.maxValue;
        ReCaver = 10.0f;
        ReCaverOK = true;

    }
	
	// Update is called once per frame
	void Update () {

        SUTAMINA.value = sutamina;
        

        if (ReCaver >= 10.0f)
        {
            ReCaverOK = true;
        }
        else
        {
            ReCaverOK=false;
            ReCaver += Time.deltaTime;
        }
        if (DashFlag == true)
        {
            sutamina -= (TimeandScore.gomi + 1) * 10 * Time.deltaTime;
        }
        else
        {
            sutamina += 10*Time.deltaTime;
        }

        if (SUTAMINA.value != SUTAMINA.minValue)
        {
            Dash = (TimeandScore.gomimax-TimeandScore.gomi)/3 ;
            if (ReCaverOK == true)
            {

                if (Input.GetKey(KeyCode.LeftShift))
                {

                    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                    {
                        DashFlag = true;
                    }
                    else
                    {
                        DashFlag = false;
                    }
                }
                else
                {
                    DashFlag = false;
                }
            }
        }
        else//スタミナが0まで下がったら10秒間ダッシュ出来なくする
        {
            DashFlag = false;
            Dash = 0.5f;
            ReCaverOK = false;
            ReCaver = 0;
            sutamina += Time.deltaTime;

        }
        

        //sutaminaが上限下限を超えないように調整
        if (sutamina <= SUTAMINA.minValue)
        {
            sutamina = SUTAMINA.minValue;
        }
        if (sutamina >= SUTAMINA.maxValue)
        {
            sutamina = SUTAMINA.maxValue;
        }

       // //青色に変更
       //SUTAMINA.fillRect. = Color.blue;

       // //変更後の色コンソールに出力
       // Debug.Log(myCube.renderer.material.color);
    }
}
