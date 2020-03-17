using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public Text scoreText, bestScoreText , missCount;
    public GameObject chacterSelectionPanel,ToggleButton;
    public NormalBall box;
    void Start()
    {
        
    }

    
    void Update()
    {
      
            scoreText.text = ScoreManager.Instance.score.ToString();
            bestScoreText.text = ScoreManager.Instance.highScore.ToString();
            missCount.text = box.missCount.ToString();
        
    }

public void EnableCharacterSelectionPanel()
    {
        ToggleButton.gameObject.SetActive(false);
        chacterSelectionPanel.gameObject.SetActive(true);
    }
    public void DisableCharacterSelectionPanel()
    {
        ToggleButton.gameObject.SetActive(true);
        chacterSelectionPanel.gameObject.SetActive(false);

    }

    public void share()
    {

        new NativeShare().SetText("http://google.com").Share();

    }
}
