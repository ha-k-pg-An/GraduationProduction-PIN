using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private float speed;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        speed = -10.0f;
        //������180�x��]
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

            //GameObject"tire"�̎q���ƂȂ�A�^�C���Ƌ��ɉ�]����
            transform.parent = obj.transform;
            
        }

        if(collision.tag == "Pin")
        {
            //GameOver�̏���

        }
    }

}
