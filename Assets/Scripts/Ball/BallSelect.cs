using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSelect : MonoBehaviour
{
    public int selectedBall= 0;

    void Start()
    {
        if (PlayerPrefs.HasKey("Ball"))
        selectedBall = PlayerPrefs.GetInt("Ball", 0);
        SelectedBall();
    }

    public void character1()
    {
        if (transform.childCount >= 1)
        selectedBall = 0;
        PlayerPrefs.SetInt("Ball", 0);
        SelectedBall();
    }

    public void character2()
    {
       if (transform.childCount >= 2)
        selectedBall = 1;

        PlayerPrefs.SetInt("Ball", 1);
        SelectedBall();

    }
    public void character3()
    {
      if (transform.childCount >= 3)
            selectedBall = 2;

        PlayerPrefs.SetInt("Ball", 2);
        SelectedBall();
    }

    public void character4()
    {
       if (transform.childCount >= 4)
            selectedBall = 3;

        PlayerPrefs.SetInt("Ball", 3);
        SelectedBall();
    }
    void SelectedBall()
    {

        int i = 0;
        foreach (Transform ball in transform)
        {
            if (i == selectedBall)
               ball.gameObject.SetActive(true);
            else
                ball.gameObject.SetActive(false);
            i++;


        }



    }
}
