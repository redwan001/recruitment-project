﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();


        if (ScoreManager.Instance.missing >= 5 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            NormalBall.missCount = 0;
        }
    }
}
