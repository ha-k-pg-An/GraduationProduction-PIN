using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{
    public Text ResultScore;
//    public GameObject obj;

    private int resultScore;

    // Start is called before the first frame update
    void Start()
    {
 //       obj = GameObject.Find("GameController");
        resultScore = PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
 //     resultScore = obj.GetComponent<GameObject>().GetScore();
        ResultScore.text = "Your score is "+ resultScore;

    }
}
