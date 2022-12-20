using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text ScoreUi;
    public Text StartCountdown;
    public Text AddScoreHint;
    public GameObject gameOver;
    public GameObject pinFactory;
    public bool TireHit;

    private int score;
    private bool isOver;
    private float startTimer;
    private float endTimer;
    private float AddScoreUItimer;

    // Start is called before the first frame update
    void Start()
    {
        TireHit = false;
        score = 0;
        isOver = false;
        startTimer = 3.5f;
        endTimer = 3.0f;
        AddScoreUItimer = 1.0f;
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUi.text = "Score:" + score;
        //Debug.Log(score);

        startTimer -= Time.deltaTime;
        StartCountdown.text = ""+ (int)startTimer;
        if(startTimer <= 0.0f)
        {
            pinFactory.GetComponent<PinFactry>().ResumePin();
            StartCountdown.text = "";
        }

        if(isOver == true)
        {
            endTimer -= Time.deltaTime;
            pinFactory.GetComponent<PinFactry>().StopPin();
            if (endTimer <= 0.0f)
            {
                PlayerPrefs.SetInt("Score", score);
                //���ʃV�[����
                SceneManager.LoadScene("Result");
            }

        }

        //score��������ui�\������
        if(TireHit == true)
        {
            AddScoreUItimer -= Time.deltaTime;
            AddScoreHint.text = "+10";
            if(AddScoreUItimer <= 0.0f)
            {
                TireHit = false;
                AddScoreUItimer = 1.0f;
            }
            
        }
        else
        {
            AddScoreHint.text = "";
        }

       // Debug.Log(TireHit);
    }

    public void AddScore(int add_value)
    {
        score += add_value;     
        TireHit = true;
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetGame() 
    {
        score = 0;
        isOver = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        isOver= true;
    }
}
