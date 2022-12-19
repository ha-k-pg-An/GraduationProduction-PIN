using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int score)
    {
        Text text_obj = GetComponent<Text>();
        /*
            C#の文字連結　=> [ + ]
            変数名.ToString => 変数の値を文字列に変換してくれる
         */
        text_obj.text = "Score:" + score.ToString();
    }
}
