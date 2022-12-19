using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinFactry : MonoBehaviour
{
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ÉsÉìê∂ê¨
            Instantiate(Prefab, transform.position, Quaternion.identity);
        }
        
    }
}
