using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class showHighScore : MonoBehaviour
{
    private int highScore;
    public Text highScoreText1;
    void Awake()
    {
        
        LoadScore1();  // LOAD DATA ON AWAKE 
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText1.text = highScore.ToString();
    }

    public void LoadScore1()
    {
        PlayerData data = saveSystem.LoadPlayer();

        highScore = data.highScore;
    
    }
}
