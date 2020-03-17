using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{

    public Text highscore2;
    public int highScore1;
    void Awake()
    {
       
        LoadScore();  
    }

    private void Update()
    {
        highscore2.text = highScore1.ToString();
    }


    public void LoadScore()
    {
        PlayerData data = saveSystem.LoadPlayer();

        highScore1 = data.highScore;
    }


}
