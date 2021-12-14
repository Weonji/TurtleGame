using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public static int score = 0;

    public Text scoreText;
    public Text highScoreText;

    private int savedscore = 0;
    private string KeyString = "HighScore";
    private string tmpScore = "ScoreText";
  

    private void Awake()
    {
        savedscore = PlayerPrefs.GetInt(KeyString, 0);
        highScoreText.text = "High Score:" + savedscore.ToString("0");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int score = PlayerPrefs.GetInt(tmpScore,0);
        scoreText.text = "score:" + score.ToString("0");

        if (score > savedscore)
        {
            PlayerPrefs.SetInt(KeyString, score);

            savedscore = PlayerPrefs.GetInt(KeyString, 0);
            highScoreText.text = "High Score:" + savedscore.ToString("0");
        }
    }
    public void ScoreUp()
    {
        score++;
    }
}
