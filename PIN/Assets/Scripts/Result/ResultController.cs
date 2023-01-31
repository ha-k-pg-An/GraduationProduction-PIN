using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ResultController : MonoBehaviour
{
    public Text ResultScore;
    private int resultScore;

    // Start is called before the first frame update
    void Start()
    {
        resultScore = PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
        ResultScore.text = "Your score is "+ resultScore;
    }
}
