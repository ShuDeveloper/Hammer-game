using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pousePanel;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject StartPanel;
    [SerializeField] Player playerScript;

    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] TextMeshProUGUI BallText;
    [SerializeField] TextMeshProUGUI ScoreText1;
    [SerializeField] TextMeshProUGUI BallText1;

    public int ball_count = 0;
    public float Score = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        StartPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreValiue();
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
    }
    public void PuseGame()
    {
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        ball_count = 0;
    
    }
    public void Quit()
    {
        Application.Quit();
    }
  
    public void gameOver()
    {
        //hammer of player commonet script disable
        playerScript.enabled = false;

        BallText1.text = BallText.text;
        ScoreText1.text = ScoreText.text;
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;

    }

    void ScoreValiue()
    {
        //int inScore;
        Score += Time.deltaTime* 5;

        //print("score = " + (int)Score);
        ScoreText.text = "Score:"+(int)Score;
    }
    public void BallCount(int ball)
    {
        ball_count += ball;
        BallText.text = "Ball:"+ball_count.ToString();
        //print("ball = " + ball_count);
    }


}
