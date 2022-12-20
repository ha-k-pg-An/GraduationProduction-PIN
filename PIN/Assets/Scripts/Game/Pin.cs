using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{    
    public GameObject obj;
    public GameObject obj2;

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = -10.0f;

        //初期化180度回転
        transform.Rotate(0.0f, 0.0f, 180.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, speed * Time.deltaTime, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tire")
        {
            speed = 0.0f;

            //GameObject"tire"の子供となり、タイヤと共に回転する
            transform.parent = obj.transform;

            obj2.GetComponent<GameController>()
                .AddScore(10);
           // obj2.GetComponent<GameController>()
               // .TireHit = true;
        }

        if(collision.tag == "Pin")
        {
            //GameOverの処理
            obj2.GetComponent<GameController>().GameOver();
        }
    }

}
