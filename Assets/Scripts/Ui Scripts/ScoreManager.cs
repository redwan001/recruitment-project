using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score , highScore , missing;
 
   
    void Start()
    {
    }

    void Awake()
    {
        Instance = this;
        LoadScore();  // LOAD DATA ON AWAKE 
    }
    private void Update()
    {
      
    }


    // Update is called once per frame
    public void AddScore(int ammount)
    {
     
        score += ammount;
        HighScoreUpdate();
        saveSystem.saveScore(this);

    }
    public void LoadScore()
    {
        PlayerData data = saveSystem.LoadPlayer();
        
        highScore = data.highScore;
    }
    public void HighScoreUpdate()
    {
        if(score > highScore)
        {
            highScore = score;
        }
    }

    public void missed()
    {
       int missNumber = FindObjectOfType<NormalBall>().throwCount - FindObjectOfType<NormalBall>().hitCount;
        missing = missNumber;
    }




}
