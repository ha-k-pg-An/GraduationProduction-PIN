using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreUi;
    public Text StartCountdown;
    public GameObject gameOver;
    public GameObject pinFactory;

    private int score;
    private bool isOver;
    private float startTimer;
    private float endTimer;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        isOver = false;
        startTimer = 3.5f;
        endTimer = 3.0f;
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
            if(endTimer <= 0.0f)
            {
                //Œ‹‰ÊƒV[ƒ“‚Ö

            }

        }
    }

    public void AddScore(int add_value)
    {
        score += add_value;
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
