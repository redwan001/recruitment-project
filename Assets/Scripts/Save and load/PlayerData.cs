using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int score;
    public int highScore;


    public PlayerData (ScoreManager player)
    {
        score = player.score;
        highScore = player.highScore;
       
    }
}
