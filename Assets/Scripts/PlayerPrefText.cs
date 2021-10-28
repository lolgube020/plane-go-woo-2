﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerPrefText : MonoBehaviour
{
    public static int score;
    private void Awake()
    {
        score = 0;
    }
    // why is this here??  (think it not being here broke something before so just ignore it i guess)
    //public string name;

    

    // gets our text, sets it as the playerpref "score"
    private void Update() { 
        // get score
        score = PlayerPrefs.GetInt("Score");

        // display score, d10 stands for 10 decimals, keeping it old school and cool
        GetComponent<TMP_Text>().text = score.ToString("D10");
        //print(score);

        // debug 3
        if(Input.GetKeyDown(KeyCode.K)){
            PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+ 1000);
            print("ligma");
        }
    }
}