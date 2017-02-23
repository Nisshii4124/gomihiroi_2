using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Sutamina : MonoBehaviour {

    public float Dash;    //ダッシュの倍率
    public bool DashFlag; //ダッシュできるかどうか

    public float sutamina;//スタミナ
    Slider SUTAMINA;

    testmove player;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        SUTAMINA = GameObject.Find("Slider").GetComponent<Slider>();
        player = GetComponent<testmove>();
        

        sutamina = SUTAMINA.maxValue;
    }
	
	// Update is called once per frame
	void Update () {

        SUTAMINA.value = sutamina;

        if (SUTAMINA.value != 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift)&&rb.velocity.magnitude!=0)
            {
                sutamina -= Time.deltaTime;
                
            }
        }

	}
}
