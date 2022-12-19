using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tire : MonoBehaviour
{
    private float speed;        //回転スピード

    enum RotateStep     //タイヤの回転タイプ
    {
        STOPPING,            
        SLOWLEFT,           
        SLOWRIGHT,
        FASTLEFT,
        FASTRIGHT,
    }

    private float timeCounter;
    private RotateStep rotateStep;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0f;
        timeCounter = 0.0f;
        rotateStep = RotateStep.STOPPING;
    }

    // Update is called once per frame
    void Update()
    {
        switch(rotateStep)
        {
            case RotateStep.STOPPING:
                Stopping();
                break;
            case RotateStep.SLOWLEFT:
                SlowLeft();
                break;
            case RotateStep.SLOWRIGHT:
                SlowRight();
                break;
            case RotateStep.FASTLEFT:
                FastLeft();
                break;
            case RotateStep.FASTRIGHT:
                FastRight();
                break;
        }

        transform.Rotate(0.0f, 0.0f, speed*Time.deltaTime);
        timeCounter += Time.deltaTime;
        if(timeCounter >= 1.5f)
        {
            rotateStep = (RotateStep)Random.Range(0, 5);
            timeCounter = 0.0f;
        }

    }

    private void Stopping()
    {
        speed--;
        if(speed <= 0.0f)
        {
            speed = 0.0f;
        }
    }

    private void SlowLeft()
    {
        speed = 100.0f;
    }

    private void SlowRight()
    {
        speed = -100.0f;
    }

    private void FastLeft()
    {
        speed = 200.0f;
    }

    private void FastRight()
    {
        speed = -200.0f;
    }



    
}
