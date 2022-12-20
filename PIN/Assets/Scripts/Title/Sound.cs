using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private static Sound m_Instance = null;

    private static Sound Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType(typeof(Sound)) as Sound;
            }

            if (m_Instance == null)
            {
                Debug.Log("Singletonを設定しているオブジェクトがありません");
                return null;
            }

            return m_Instance;
        }
    }

    private void Awake()
    {
        if (this != Instance)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        if (source != null)
        {
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
