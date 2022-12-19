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
            C#‚Ì•¶š˜AŒ‹@=> [ + ]
            •Ï”–¼.ToString => •Ï”‚Ì’l‚ğ•¶š—ñ‚É•ÏŠ·‚µ‚Ä‚­‚ê‚é
         */
        text_obj.text = "Score:" + score.ToString();
    }
}
