using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinFactry : MonoBehaviour
{
    public GameObject Prefab;

    private bool canOperate;

    // Start is called before the first frame update
    void Start()
    {
        canOperate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(canOperate == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //�s������
                Instantiate(Prefab, transform.position, Quaternion.identity);
            }
        }        
    }

    public void ResumePin()
    {
        canOperate = true;
    }
}
